using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorScript : MonoBehaviour
{
    public GameObject monitorUI;
    public Button button1;
    public Button button2;
    public Button button3;
    public LayerMask monitorMask;
    public Camera playerCam;
    private bool monitorOpen = false;

    public MonitorUIScript canvasController;
    // Start is called before the first frame update
    void Start()
    {
        monitorUI.SetActive(false);

        button1.onClick.AddListener(() => ButtonSelected(1));
        button2.onClick.AddListener(() => ButtonSelected(2));
        button3.onClick.AddListener(() => ButtonSelected(3));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !monitorOpen){
            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, monitorMask)){
                if(hit.collider != null && hit.collider.gameObject == gameObject){
                    ToggleMonitorUI();
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape) && monitorOpen){
            ToggleMonitorUI();
        }
    }


    private void ToggleMonitorUI(){
        monitorOpen = !monitorOpen;
        monitorUI.SetActive(monitorOpen);

        canvasController.monitorInteractionOnly(monitorOpen);
    }
    private void ButtonSelected(int numButton){

    }
}
