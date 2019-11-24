using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centipede : MonoBehaviour
{
    public float moveSpeed;

    public Centipede NextPart;
    public GameObject Mushroom;

    public Material HeadMaterial;
    public Material BodyMaterial;
    public Transform LevelParent;

    GameObject spawnedMush;

    Renderer _rend;

    float currentY;

    public bool isHead;

    public enum MoveState
    {
        IntoScreen,
        Descending,
        Ascending,
        MushroomCollision,
    };

    public MoveState moveState;

    bool Left;

    private void Awake()
    {
        _rend = GetComponent<Renderer>();
        _rend.material = BodyMaterial;

    }
    private void Start()
    {
        moveState = MoveState.IntoScreen;
        Left = Random.Range(0, 1) == 0;
        LevelParent = GameObject.Find("Level").transform;

    }

    private void FixedUpdate()
    {
        switch (moveState)
        {
            case MoveState.IntoScreen:
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(15, 30), moveSpeed * Time.deltaTime);
                if(Vector3.Distance(transform.localPosition, new Vector3(15,30)) < 0.01f)
                {
                    moveState = MoveState.Descending;
                }
                break;

            case MoveState.Descending:

                float xDest = Left ? 0 : 30;
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(xDest, transform.localPosition.y), moveSpeed * Time.deltaTime);
                currentY = transform.localPosition.y;

                if (Vector3.Distance(transform.localPosition, new Vector3(xDest, transform.localPosition.y)) < 0.01f)
                {
                    moveState = MoveState.MushroomCollision;
                }
                break;

            case MoveState.MushroomCollision:

                transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, currentY -1), moveSpeed * Time.deltaTime);
                if (Vector3.Distance(transform.localPosition, new Vector3(transform.localPosition.x, currentY - 1)) < 0.01f)
                {
                    Left = !Left;
                    moveState = MoveState.Descending;
                }
                break;

        }

        if (NextPart == null)
        {
            ChangeToHead();
        }
    }

    void ChangeToHead()
    {
        _rend.material = HeadMaterial;
        isHead = true;
    }


    public void GetHit()
    {
        spawnedMush = (GameObject)Instantiate(Mushroom, transform.position, Quaternion.identity);
        spawnedMush.transform.SetParent(LevelParent);
        spawnedMush.transform.localScale = Vector3.one;
        spawnedMush.transform.localPosition = new Vector3(Mathf.Round(spawnedMush.transform.localPosition.x), Mathf.Round(spawnedMush.transform.localPosition.y));

        if(isHead)
        {
            Stats.CentipedeHeadsShot++;
            Stats.Score += 100;
        }
        else
        {
            Stats.CentipedeBodiesShot++;
            Stats.Score += 10;
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Mushroom"))
        {
            moveState = MoveState.MushroomCollision;
        }
    }

}
