using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float kecepatan;
    public string xAxis;
    public string yAxis;

    public float batasAtas;
    public float batasBawah;
    public float batasKiri;
    public float batasKanan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float gerakVertical = Input.GetAxis(yAxis) * kecepatan * Time.deltaTime;
        float gerakHorizontal = Input.GetAxis(xAxis) * kecepatan * Time.deltaTime;
        
        float nextPosY = transform.position.y + gerakVertical;
        float nextPosX = transform.position.x + gerakHorizontal;
        if(nextPosY > batasAtas){
            gerakVertical = 0;
        }
        if(nextPosY < batasBawah){
            gerakVertical = 0;
        }
        if(nextPosX < batasKiri){
            gerakHorizontal = 0;
        }
        if(nextPosX > batasKanan ){
            gerakHorizontal = 0;
        }

        transform.Translate(gerakHorizontal, gerakVertical, 0);

    }
}
