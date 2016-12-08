using UnityEngine;
using System.Collections;

public class PlayerBubble : MonoBehaviour {

    public NavMeshAgent playerNav;
    public int PersonalBubble;

    void Start()
    {
        playerNav.radius = PersonalBubble;
    }
}
