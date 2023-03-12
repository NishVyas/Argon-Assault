using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnParticleCollision(GameObject other) {
        Debug.Log($"{this.name}: I'm hit! By {other.gameObject.name}");
        Destroy(gameObject);
    }
}
