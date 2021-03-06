using UnityEngine;
using System.Collections;

public class Quest1CinematicBegin : CinematicEvent 
{
	public override void onPlay()
	{
		Game game = Game.game;
		game.currentState = Game.GameStates.Cinematic;
		game.allowEnemySpawn = false;
		
		GameObject hero = GameObject.Find("Hero");
		Animation hero_anim = hero.AddComponent<Animation>();
		AnimationClip hero_anim_clip = Resources.Load("Cinematics/Quest1/hero_begin") as AnimationClip;
		hero_anim.AddClip(hero_anim_clip,"cinematic");
		hero_anim.Play("cinematic");
		
		string[] enemiesClips = 
		{
			 "Cinematics/Quest1/reaper1_begin"
			,"Cinematics/Quest1/bat1_begin"
			,"Cinematics/Quest1/bat2_begin"
		};
		
		string[] enemiesPrefabs = 
		{
			 "Prefabs/Enemies/Reaper"
			,"Prefabs/Enemies/Bat"
			,"Prefabs/Enemies/Bat"
		};
		
		for(int i=0;i<enemiesPrefabs.Length;i++)
		{
			GameObject		prefab	= Resources.Load(enemiesPrefabs[i]) as GameObject;
			BasicEnemy		enemy	= Game.game.spawnEnemy(prefab);
			GameObject		go		= enemy.gameObject;
			
			Animation		anim	= go.AddComponent<Animation>();
			
			enemy.mustNotifyDeath = false;
			enemy.prefab = prefab;
				
			AnimationClip	clip	= Resources.Load(enemiesClips[i]) as AnimationClip;
			anim.AddClip(clip,"cinematic");
			anim.Play("cinematic");
		}
		
	}
}
