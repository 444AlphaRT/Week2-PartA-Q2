using UnityEngine;

public class turning : MonoBehaviour
{
    [SerializeField] private float speed = 100f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("starting :-)");
        GetComponent<Transform>().position = new Vector3(0,0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
