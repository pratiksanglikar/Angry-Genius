using UnityEngine;
using System.Collections;

public class UpdateTargetTextObserver : ConcreteNumberObserver {

	private int target_number = AlphaTargetTextManager.target_number;
	
	public UpdateTargetTextObserver(ConcreteAlphaState state){
		base.state = state;
	}
	
	public override void update_observer(){
		int updated_state = base.state.getState ();
		if (updated_state == AlphaTargetTextManager.target_number) {
			AlphaTargetTextManager.target_number = PlayerMovement.gameStrategy.getTarget();
			
			NumTextGen alphaGen = new NumTextGenImpl();
			
			AlphaTargetTextManager.target_number = alphaGen.getTargetNumber();
			NumberTextManager.current_addition = 0;
			
			
		}else if(updated_state > AlphaTargetTextManager.target_number){
			
			/*AlphaTextGen alphaGen=new AlphaTextGenImpl();
			
			AlphaTargetTextManager.target_alpha_string=alphaGen.getTargetString();
			
			AlphaTextManager.alpha_string="";*/ // game over state... TODO
			
		}
	}
}
