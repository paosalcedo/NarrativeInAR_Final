using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicStrip : MonoBehaviour {

	// Use this for initialization
	public Dictionary<PanelOrder, SpeechSet> comics = new Dictionary<PanelOrder, SpeechSet>(){
		{ //1
			new PanelOrder(
				1, //the view 
				2, //the mouth
				3, //the two-person shot
				4 //the closed eye
			),
			
			new SpeechSet (
				"Look at that view.",
				"I'm hungry.",
				"We literally just ate a horse.",
				"It was a unicorn, you dolt."	
			)
		},
		{ //2
			new PanelOrder(
				1, 2, 4, 3
			),
			
			new SpeechSet (
				"Whoa, is that the sun?",
				"I haven't seen it since yesterday",
				"...",
				"You lost my shades."	
			)
		},
		{ //3
			new PanelOrder(
				1, 3, 4, 2
			),
			
			new SpeechSet (
				"I'm not built for this weather.",
				"You're not built for anything.",
				"Not even love...",
				"What did I do now?!"	
			)
		},
		{ //4
			new PanelOrder(
				1, 3, 2, 4
			),
			
			new SpeechSet (
				"Are we there yet?",
				"Ask that again and I'll...",
				"Kiss me?",
				"Fat chance..."	
			)
		},
		{ //5
			new PanelOrder(
				1, 4, 3, 2
			),
			
			new SpeechSet (
				"Where the hell are we?",
				"You said you knew...",
				"I told you to steal that map!",
				"Mouths don't steal, we lie."	
			)
		},
		{ //6
			new PanelOrder(
				1, 4, 2, 3
			),
			
			new SpeechSet (
				"Ah! What a day!",
				"Thank you for kidnapping me.",
				"Of course, honey.",
				"Don't call me that."	
			)
		},
		{ //7
			new PanelOrder(
				2, 1, 3, 4
			),
			
			new SpeechSet (
				"I think we're in trouble.",
				"I have no idea where we are.",
				"What did you say?",
				"I trusted you..."	
			)
		},
		{ //8
			new PanelOrder(
				2, 1, 4, 3
			),
			
			new SpeechSet (
				"<BURP>",
				"You think they heard me?",
				"Don't know, but I smelled it.",
				"Do you even floss?"	
			)
		},
		{ //9
			new PanelOrder(
				2, 3, 1, 4
			),
			
			new SpeechSet (
				"Wait so you didn't like Metal Gear?",
				"The story is stupid.",
				"IT'S THE BEST THING EVER!!!",
				"Kojima fanboy."	
			)
		},
		{ //10
			new PanelOrder(
				2, 3, 4, 1
			),
			
			new SpeechSet (
				"Do I have anything in my teeth?",
				"Nope.",
				"...",
				"I want some ramen."	
			)
		},
		{ //11
			new PanelOrder(
				2, 4, 1, 3
			),
			
			new SpeechSet (
				"You should smile more often.",
				"I'm always smiling.",
				"The sun says you're lying.",
				"Eat sand, you loudmouth."	
			)
		},
		{ //12
			new PanelOrder(
				2, 4, 3, 1
			),
			
			new SpeechSet (
				"What did she tell you?",
				"The prophecy will be fulfilled...",
				"and you're an asshole.",
				"Some things never change."	
			)
		},
		{ //13
			new PanelOrder(
				3, 1, 2, 4
			),
			
			new SpeechSet (
				"Why is brown not dark red?",
				"It sort of is, right?",
				"Check the RGB values.",
				"But the world is black and white..."	
			)
		},
		{ //14
			new PanelOrder(
				3, 1, 4, 2
			),
			
			new SpeechSet (
				"Mouth, we have to find Nose first.",
				"They're probably in that direction.",
				"I hope so.",
				"I nose so."	
			)
		},
		{ //15
			new PanelOrder(
				3, 2, 1, 4
			),
			
			new SpeechSet (
				"Did you take a bath this morning?",
				"Uh, no... why?",
				"Who cares about hygiene out here?",
				"I do."	
			)
		},
		{ //16
			new PanelOrder(
				3, 2, 4, 1
			),
			
			new SpeechSet (
				"Can you take a photo of me?",
				"NOW?!",
				"Why not.",
				"WE'RE LOST!"	
			)
		},
		{ //17
			new PanelOrder(
				3, 4, 1, 2
			),
			
			new SpeechSet (
				"How old are you again?",
				"Please be 18.",
				"What is age but a number?",
				"I'm old enough to drink."	
			)
		},
		{ //18
			new PanelOrder(
				3, 4, 2, 1
			),
			
			new SpeechSet (
				"You left the rocket fuel at home?",
				"We can't get off-planet...",
				"We can...",
				"If you leave me here."	
			)
		},
		{ //19
			new PanelOrder(
				4, 1, 2, 3
			),
			
			new SpeechSet (
				"I can't look...",
				"Trust me, it's a great view.",
				"... If I could see that is...",
				"You can't see?"	
			)
		},
		{ //20
			new PanelOrder(
				4, 1, 3, 2
			),
			
			new SpeechSet (
				"<GROAN>",
				"Look at the bright side!",
				"THERE IS NO BRIGHT SIDE!",
				"Even the blind see a bright side."	
			)
		},
		{ //21
			new PanelOrder(
				4, 2, 1, 3
			),
			
			new SpeechSet (
				"Something's in my eye...",
				"Which eye?",
				"I can't be sure with all this sun...",
				"..."	
			)
		},
		{ //22
			new PanelOrder(
				4, 2, 3, 1
			),
			
			new SpeechSet (
				"Zzz",
				"WAKE UP!",
				"Why must you shout?",
				"You'll miss the view!"	
			)
		},
		{ //23
			new PanelOrder(
				4, 3, 1, 2
			),
			
			new SpeechSet (
				"Shhh",
				"I need to meditate.",
				"We have to keep moving!",
				"They are near."	
			)
		},
		{ //24
			new PanelOrder(
				4, 3, 2, 1
			),
			
			new SpeechSet (
				"Eat shit.",
				"I'm just kidding.",
				"Were you, now?",
				"Let's ask the horizon!"	
			)
		},
		
	};
}
