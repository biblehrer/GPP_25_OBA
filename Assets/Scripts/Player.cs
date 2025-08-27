using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 goal = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
            //navMeshAgent.SetDestination(goal); 


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;           
            if (Physics.Raycast(ray,out hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
