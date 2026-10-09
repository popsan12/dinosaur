using UnityEngine;

public class Scroller : MonoBehaviour
{

    [SerializeField] private Transform[] BG;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        foreach ( Transform t in BG )
        {
            
            t.Translate(new Vector3(-0.05f, 0, 0));
            if (t.transform.position.x <= -15)
                {
                    t.Translate(new Vector3(30, 0, 0));
                }
        }
    }
}
