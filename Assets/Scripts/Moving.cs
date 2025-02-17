using UnityEngine;

public class Moving : MonoBehaviour
{
    public KeyCode moveKey;
    public float cubeSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveKey)){
            transform.position = transform.position + Vector3.up * cubeSpeed * Time.deltaTime;
        }
    }
}
