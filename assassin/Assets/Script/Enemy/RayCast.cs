using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private AudioSource _audioSource;
    
    private RayCast _rayCast;
    private Collider2D collider;
    private EnemyMove EnemyMove;
    private Target target;
    
    public float angle = 1.5f;
    public int maxDistance = 5;

    public float x_min = -0.5f;
    public float x_max = 0.5f;

    float[,] rotationMatrix;
    List<Vector3> rays = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        
        _rayCast = this.GetComponent<RayCast>();
        collider = this.GetComponent<Collider2D>();
        EnemyMove = this.GetComponent<EnemyMove>();
        target = this.GetComponent<Target>();
        for (int i = 0; i < 20; i++)
        {


                rays.Add(new Vector3(0,0, 0));


        }
    }

    // Update is called once per frame
    void Update()
    {
            //foreach (Vector3 ray in rays)
            //{
            //    Vector3 cos = transform.TransformDirection(ray);

            //    Vector3 startRay = this.transform.position;
            //    startRay += new Vector3(0, 2f, 0);

            //    RaycastHit2D hit = Physics2D.Raycast(startRay, ray, maxDistance);

            //    Debug.DrawRay(startRay, ray * maxDistance, Color.red);

            //    if (hit)
            //    {
            //        if (hit.transform.CompareTag("Player"))
            //            Debug.Log("hithit");
            //    }
            //}


        float x = (float)x_min;
        angle = this.transform.rotation.z / -0.453f;

      
        foreach (Vector3 ra in rays)
        {
            if (x_max > x)
            {

                Vector3 startRay = this.transform.position;
              

                rotationMatrix = new float[2, 2] { { Mathf.Cos(angle), Mathf.Sin(angle) }, { Mathf.Sin(angle) * -1, Mathf.Cos(angle) } };

                    float y = Mathf.Cos((float)0);
                    //matrix 
                    float[] position = new float[] { x, y };


                    float[] sum1 = new float[] { 0, 0 };
                    float[] sum2 = new float[] { 0, 0 };

                    sum1[0] = rotationMatrix[0, 0] * position[0];
                    sum1[1] = rotationMatrix[1, 0] * position[0];
                    sum2[0] = rotationMatrix[0, 1] * position[1];
                    sum2[1] = rotationMatrix[1, 1] * position[1];

                    float[] res = new float[] { sum1[0] + sum2[0], sum1[1] + sum2[1] };

                    Vector3 ray = new Vector3(res[0], res[1], 0);


                    Vector3 cos = transform.TransformDirection(ray);

                    startRay += new Vector3(0, 0, 0);

                //감지
                //감지
                Physics2D.queriesHitTriggers = false;
                RaycastHit2D hit = Physics2D.Raycast(startRay, ray, maxDistance);
                    
                    

                    x += 0.1f;
                
                if (hit)
                {
                    if (hit.transform.CompareTag("Player"))
                    {
                        _audioSource.Play();
                        collider.isTrigger = false;
                        EnemyMove.enabled = false;
                        target.enabled = true;
                        _rayCast.enabled = false;
                        
                    }
                    
                }
                else
                {
                    Debug.DrawRay(startRay, ray * maxDistance, Color.red);
                }
            }
        }

          


    }
}