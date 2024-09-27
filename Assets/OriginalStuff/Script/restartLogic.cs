using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartLogic : MonoBehaviour
{
    private GameObject[] originalItem;
    private GameObject[] anomalyItem;
    private gameLogic restartScript;
    // Start is called before the first frame update
    void Awake()
    {
        originalItem = GameObject.FindGameObjectsWithTag("origins");
        anomalyItem = GameObject.FindGameObjectsWithTag("anomalies");
        GameObject startObject = GameObject.Find("GameLogic");
        restartScript = startObject.GetComponent<gameLogic>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider gameState){
        if(gameState.CompareTag("endGame")){
            ReturnOriginal();
        }else if(gameState.CompareTag("startGame")){
            startAnom();
        }
    }

    private void ReturnOriginal(){
        Debug.Log("The level is restarted");
        foreach(GameObject org in originalItem){
            Debug.Log("Object " + org + " Activated");
            org.SetActive(true);
        }

        foreach(GameObject anom in anomalyItem){
            Debug.Log("Object " + anom + " Inactivated");
            anom.SetActive(false);
        }
    }

    private void startAnom(){
        Debug.Log("The level anomaly is randomized");
        restartScript.randomAnom();
    }
}
