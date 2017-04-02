#ifndef CHARACTER_CLASS_HPP   
#define CHARACTER_CLASS_HPP  
                  
#include<string> 
#include<Vector>
#include<iostream>


//========================================================================================================================
//char_data class
//A class that will hold the values of characters throughout the game.
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
	std::string char_rank;
public:
};
//=======================================================================================================================
//							++END OF char_data ADT++ 
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
	int wisdom; //6.) A character's knowledge of the world, their ability to harness specific ancient spells or summonings. 
	int percepetion; //7.) A character's ability to detect clues, traps, hidden enemies, etc.
	//-----------------------------------------------------------------------------------------------------------------------
	//Derived Stats-Stats that are derived from the primary stats.
	int base_health; //8.) A character's total health;
	int current_health; //9.) A character's current health;
	int base_stamina; //10.) A character's total stamina;
	int current_stamina; //11.) A character's current stamina;
	int base_magic; //12.) A character's total magic enery.
	int current_magic; //13.) A character's total amount of stamina;
	double weapon_crit; //14.) A character's chance of landing a critical strike with a weapon. 
	double magic_crit;  //15.) A character's chance of landing a critical strike with a magical ability. 
	//-----------------------------------------------------------------------------------------------------------------------
	//Other Stats-These are stats that occur in the game, and have an affect on the character's derived stats.
	std::string gender;
	std::string race;
	int char_level;
	int char_age;
	std::string char_homeland;
	/*
	std::vector<double> active_affect; //A placeholder vector for buffs / debuffs, etc.
	*/
	public:
	//Constructors
	char_player_stats(); //Default constructor;
	//--------------------------------------------------------------------------------------------------------------------------
	void race_base_stats();
	void start_stats();
	void level_up();
	void health_damage();
	void stam_loss();
	void magic_loss();
};
//=======================================================================================================================
//							++END OF char_stats Class++ 
//=======================================================================================================================


//========================================================================================================================
//race class
//A class that will hold the values and information about a character's race, faction, homeland, etc.
//CREATED BY: Tyler Dickon
//CREATED ON: 2/4/2017
//Updated ON: N/A
//v.001        
//========================================================================================================================
class race
{
private:
	int race_id;
	std::string race_name;
	int homeland_id;
	std::string homeland_name;
	int faction_id;
	std::string faction_name;
	public:
	//Constructors
	race() : race_id(0), race_name('\0'), homeland_id(0), homeland_name('\0'), faction_id(0), faction_name('\0') {};
	race(const int &, const std::string &, const int &, const std::string &, const int &, const std::string &); //Unique NPCS CTOR 
	//Relational Methods -- including relational operators to allow the player to be able to track down particular NPCs for quests. 
	bool operator==(const race&);
	bool operator<(const race &);
	bool operator>(const race &);
	bool operator!=(const race &);
	//Copy Methods -- This will allow us to set player classes, copy over generic npcs, etc.
};
//=======================================================================================================================
//							++END OF race Class++ 
//=======================================================================================================================

#endif
