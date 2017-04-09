#ifndef CHARACTER_CLASS_HPP   
#define CHARACTER_CLASS_HPP  

#include<string> 
#include<Vector>
#include<iostream>


//========================================================================================================================
//char_player_data class
//A class that will hold the values of our player's character throughout the game.
//CREATED BY: Tyler Dickon
//CREATED ON: 19/3/2017
//UPDATED ON: 1/4/2017 BY: Tyler Dickon
//v.001        
//========================================================================================================================
class char_player_data
{
private:
	std::string char_name;
	char_player_stats char_stats;
public:
};
//=======================================================================================================================
//++END OF char_data ADT++ 
//=======================================================================================================================

//========================================================================================================================
//char_player_stats class
//A class that will hold the values of the player character throughout the game.
//CREATED BY: Tyler Dickon
//CREATED ON: 19/3/2017
//UPDATED ON: 31/3/2017 BY: Tyler Dickon
//v.001        
//========================================================================================================================
class char_player_stats
{
private:
	//Primary Stats-Stats that the character chooses from during leveling up, which will affect their derived stats.
	int endurance; //1.) Determines a character's maximum health, their health per level, and amount of stamina per action.
	int intel;	//2.) Intelligence (intel) determines a characters apptitude for quick thinking, problem solving, etc.
	int strength; //3.) Strength determines a character's physical damage capabilities with weapons both melee and ranged.
	int charm; //4.) A character's apptitude for swindling their way through negotiations, or risky situations. 
	int stealth; //5.) A character's ability to sneak or sulk about in certain areas. 
	int wisdom; //6.) A character's knowledge of the world, the old world and how to deal with events.
	int percepetion; //7.) A character's ability to detect clues, traps, hidden enemies, etc.
	//-----------------------------------------------------------------------------------------------------------------------
	//Derived Stats-Stats that are derived from the primary stats.
	int base_health; //8.) A character's total health;
	int current_health; //9.) A character's current health;
	int base_stamina; //10.) A character's total stamina;
	int current_stamina; //11.) A character's current stamina;
	double weapon_crit; //14.) A character's chance of landing a critical strike with a weapon. 
	//-----------------------------------------------------------------------------------------------------------------------
	//Other Stats-These are stats that occur in the game, and have an affect on the character's derived stats.
	std::string char_gender;
	int char_age;
	std::string former_job;
	int level;
	/*
	std::vector<double> active_affect; //A placeholder vector for buffs / debuffs, etc.
	*/
public:
	//Constructors
	char_player_stats(); //Default constructor; 
	char_player_stats(int, int, int, int, int, int, int, int, int, int, int, double, std::string, int, int);
	//Base Mutators
	void start_stats();
	//In Game Mutators
	void level_up();
	void health_damage();
	void stam_loss();
};
//=======================================================================================================================
//++END OF char_stats Class++ 
//=======================================================================================================================

#endif
