using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashVFX;
    
    void OnTriggerEnter(Collider other) 
    {
        StartCrashSequence();
    }

    void StartCrashSequence()
    {
        crashVFX.Play();
        
        GetComponent<PlayerControls>().enabled = false;
        foreach (MeshRenderer meshInChild in GetComponentsInChildren<MeshRenderer>())
        {
            meshInChild.enabled = false;
        }
     
        foreach (Collider colliderInChild in GetComponentsInChildren<Collider>())
        {
            colliderInChild.enabled = false;
        }

        Invoke("ReloadLevel", loadDelay); 
    }

    void ReloadLevel() 
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
