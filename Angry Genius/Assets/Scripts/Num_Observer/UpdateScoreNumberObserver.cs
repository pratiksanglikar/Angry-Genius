using UnityEngine;
using System.Collections;

public class UpdateScoreNumberObserver : ConcreteNumberObserver {

    public UpdateScoreNumberObserver(ConcreteAlphaState state){
		base.state = state;
	}
	
	public override void update_observer(){
		int updated_state = base.state.getState ();
		if(updated_state == AlphaTargetTextManager.target_number) {
			ScoreManager.score = ScoreManager.score + PlayerMovement.gameStrategy.getWinningScore();
		} else if(updated_state > AlphaTargetTextManager.target_number) {
            ScoreManager.score = 0;
        }
	}
}