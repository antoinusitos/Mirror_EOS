using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    public GameObject cam = null;

    private void Start()
    {
        if(isLocalPlayer)
        {
            cam.SetActive(true);
        }
    }

    private void Update()
    {
        if(isLocalPlayer)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            transform.position += new Vector3(h, 0, v) * Time.deltaTime * 20;
        }
    }
}
