using UnityEngine;
using UnityEngine.AI;

public class NavigationScript : MonoBehaviour
{
  private NavMeshAgent agent;
  public Transform player;

  // Start is called before the first frame update
  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  void Update()
  {
    agent.SetDestination(player.position);
  }
}
