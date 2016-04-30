using UnityEngine;
using System.Collections;
public class Difficult : MonoBehaviour, DifficultyStrategy
{

	public Difficult ()
	{
	}

	public void instantiate() {
		EnemyAttack._setAttackDamage (15);
		PlayerShooting._setDamagePerShot (10);
	}

	public void calculateScore() {

			Debug.Log("Difficulty : " + gameObject.CompareTag ("Zombunny"));
			if (gameObject.CompareTag ("Zombunny")) {
			//	gameObject.GetComponent<EnemyHealth> ().scoreValue -= 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 5);
			} 
			if (gameObject.CompareTag ("Zombear")) {
				// gameObject.GetComponent<EnemyHealth> ().scoreValue -= 5;
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 5);
			}
			if (gameObject.CompareTag ("Hellephant")) {
				ScoreManager.score += (gameObject.GetComponent<EnemyHealth> ().scoreValue - 10);
			} 
	}

    public int getTarget()
    {
        return 100;
    }

    public string[] getNumbersForAddition()
    {
        string[] array = { "8", "9", "-17", "15", "22", "34", "46", "7", "3", "3", "-1", "4", "-2", "5", "6", "7", "-9" };
        return array;
    }

    public int getWinningScore()
    {
        return 200;
    }
}


