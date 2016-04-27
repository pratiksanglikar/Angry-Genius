using UnityEngine;
using System.Collections;

public interface DifficultyStrategy
{
	void instantiate();
	void calculateScore();
    int getTarget();
    string[] getNumbersForAddition();
    int getWinningScore();
}


