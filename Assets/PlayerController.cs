using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
  private NavMeshAgent agent;
  // Start is called before the first frame update
  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(movePosition, out RaycastHit hit))
      {
        agent.SetDestination(hit.point);
      }
    }
  }
}
