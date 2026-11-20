using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float obstacleSpeed;
    [SerializeField] Transform player;
    Vector3 playerPosition;


    private void Awake()
    {
        gameObject.SetActive(false);    
    }

    private void Start()
    {
        playerPosition = player.transform.position;
    }

    private void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        // Towards = ~ÇâÇÏ¿©
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, obstacleSpeed * Time.deltaTime);
    }
}
