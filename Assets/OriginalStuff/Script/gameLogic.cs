using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic : MonoBehaviour
{
    public GameObject anomaly1Origin;
    public GameObject anomaly1V2Changed;
    public GameObject anomaly1Changed;
    bool anomaly1State;
    bool anomaly2State;
    private bool newLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        anomaly1State = false;
        anomaly2State = false;
        
        
        int numAnomaly = Random.Range(0,3);
        while(numAnomaly > 0){
            int activateAnomaly = Random.Range(1,3);
            if(activateAnomaly == 1 && anomaly1State == false){
                anomaly1State = true;
                if(Random.Range(0,2) == 1){
                    anomaly1Second();
                    Debug.Log("Anomaly 1 V.2 Activated");
                }else{
                    anomaly1();
                    Debug.Log("Anomaly 1 Activated");
                }
            }else if(activateAnomaly == 2 && anomaly2State == false){
                anomaly2State = true;
                anomaly2();
                Debug.Log("Anomaly 2 Activated");
            }else{
                continue;
            }

            numAnomaly--;
        }
    }

    void anomaly1(){
        anomaly1Origin.SetActive(false);
        anomaly1Changed.SetActive(true);
    }

    void anomaly1Second(){
        anomaly1Origin.SetActive(false);
        anomaly1V2Changed.SetActive(true);
    }

    void anomaly2(){

    }
}
