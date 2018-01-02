using UnityEngine;

public class Rotator : MonoBehaviour
{

    public Transform verRot;
    public Transform horRot;
    public GameObject player;
    Vector3 playerPos;
    public GameObject me;

    // Use this for initialization
    void Start()
    {
        playerPos = player.transform.position;
        me = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += player.transform.position - playerPos;
        playerPos = player.transform.position;

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        transform.RotateAround(playerPos,Vector3.up,X_Rotation * Time.deltaTime * 200f);
        //transform.RotateAround(playerPos,, -Y_Rotation * Time.deltaTime * 200f);
    }
}