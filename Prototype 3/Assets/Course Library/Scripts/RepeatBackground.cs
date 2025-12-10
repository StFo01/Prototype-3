using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 starPos;
    private float repeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        starPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < starPos.x - repeatWidth)
        {
            transform.position = starPos;
        }
    }
}
