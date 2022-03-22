using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector2 mouseTurn;
    public float sensitivity = .5f;
    public Image image1;
    public Image image2;

    //for the xp bar
    public int addBar;
    public Image[] filler = new Image[4];


    


    private void Start()
    {
        Invoke("deletePoster", 10);
    }
    void Update()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(player);

        Rotate();
        addBar++;
        if (addBar % 100 ==0)
        {
            Destroy(filler[addBar / 100]);
        }
    }

    void Rotate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * offset;
    }

    void deletePoster()
    {
        Destroy(image1);
        Destroy(image2);
    }
}