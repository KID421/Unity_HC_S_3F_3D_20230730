using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("�I�쪺����G" + hit.gameObject);
    }
}
