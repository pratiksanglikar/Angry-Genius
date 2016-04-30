using UnityEngine;
using System.Collections;
public class Easy : MonoBehaviour, DifficultyStrategy
{

	public Easy () {
	}

	public void instantiate() {
		EnemyAttack._setAttackDamage (5);
		PlayerShooting._setDamagePerShot (20);
	}

	public void calculateScore() {

			Debug.Log("Easy : " + gameObject.GetComponents<EnemyHealth> ());
			if (gameObject.CompareTag ("Zombunny")) {
				//gameObject.GetComponent<EnemyHealth> ().scoreValue += 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue + 5);
			} 
			if (gameObject.CompareTag ("Zombear")) {
				//gameObject.GetComponent<EnemyHealth> ().scoreValue += 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue + 5);
			}
			if (gameObject.CompareTag ("Hellephant")) {
				//gameObject.GetComponent<EnemyHealth> ().scoreValue += 10;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue + 10);
			}
	}

    public int getTarget() {
        return 10;
    }

    public string[] getNumbersForAddition() {
        string[] array = { "3", "-1", "4", "-2", "5"};
        return array;
    }

    public int getWinningScore() {
        return 20;
    }
}

