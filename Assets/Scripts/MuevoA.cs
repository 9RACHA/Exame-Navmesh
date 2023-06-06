using UnityEngine;
using UnityEngine.AI;

public class MuevoA : MonoBehaviour {

   public Transform Objetivo;

    //Al incrementar la velocidad el comportamiento se vuelve mas erratico, solo mejora en las rectas
    // public float speed = 15f;

   void Start () {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
      agent.destination = Objetivo.position;

     // agent.speed = speed; // Incrementa la velocidad del agente
   }
}

