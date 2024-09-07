using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float distance {get; set;}
    private float height {get; set;}
    private float sensitivity {get; set;}
    public GameObject player;

    void Start(){
        sensitivity = 1.4F;
        distance = 4F;
        height = 2F;
    }
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
     
        Quaternion localRotation = Quaternion.Euler(0, mouseX, 0);
        transform.rotation *= localRotation;

        // Posiciona a câmera atrás do jogador
        Vector3 position = player.transform.position - transform.forward * distance;
        position.y = player.transform.position.y + height;
        transform.position = position;

        player.transform.rotation = transform.rotation;
    }
}
