using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public AudioClip deathClip;
	private DifficultyStrategy gameStrategy;


    Animator anim;
    AudioSource enemyAudio;
    ParticleSystem hitParticles;
    CapsuleCollider capsuleCollider;
    bool isDead;
    bool isSinking;


    void Awake ()
    {
        anim = GetComponent <Animator> ();
        enemyAudio = GetComponent <AudioSource> ();
        hitParticles = GetComponentInChildren <ParticleSystem> ();
        capsuleCollider = GetComponent <CapsuleCollider> ();

        currentHealth = startingHealth;
    }


    void Update ()
    {
        if(isSinking)
        {
            transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
        }
    }


    public void TakeDamage (int amount, Vector3 hitPoint)
    {
        if(isDead)
            return;

        enemyAudio.Play ();

        currentHealth -= amount;
            
        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if(currentHealth <= 0)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        anim.SetTrigger ("Dead");

        enemyAudio.clip = deathClip;
        enemyAudio.Play ();
    }


	public void StartSinking ()
	{
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		isSinking = true;

		if (ScoreManager.score >= 50 && ScoreManager.score <= 150) {
			PlayerMovement.gameStrategy = gameObject.AddComponent<Medium> ();
            Debug.Log ("Medium Level");
		}  else if (ScoreManager.score > 150) {
            PlayerMovement.gameStrategy = gameObject.AddComponent<Difficult> ();
			Debug.Log ("Hard Level");
		}  else {
            PlayerMovement.gameStrategy = gameObject.AddComponent<Easy> ();
			Debug.Log ("Easy Level");
		}
        AlphaTargetTextManager.target_number = PlayerMovement.gameStrategy.getTarget();
        PlayerMovement.gameStrategy.instantiate ();
        PlayerMovement.gameStrategy.calculateScore ();
		Destroy (gameObject, 2f);
	}
}
