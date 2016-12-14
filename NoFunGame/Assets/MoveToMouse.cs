using UnityEngine;
using System.Collections;

public class MoveToMouse : MonoBehaviour {

    NavMeshAgent myAgent;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                myAgent.destination = hit.point;
            
        }
    }
}
