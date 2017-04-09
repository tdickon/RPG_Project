//================================================================
//Created by: Tyler Dickon
//Created on: 2/4/2017
//Updated on: N/A
//Description: Class definitions for our character_data Structure.
//================================================================

#include "character_data.h"
#include<ctime>
#include<cstdlib>

//================================================================
//					CHAR_PLAYER_DATA CLASS
//	A structure that holds all of the player's stats and info.
//================================================================


//================================================================
//				++END CHAR_PLAYER_DATA CLASS++
//================================================================


//================================================================
//					CHAR_PLAYER_STATS CLASS
//		Data structure that stores all of the player's stats.
//================================================================
//----------------------------------------------------------------
//						CONSTRUCTORS
//----------------------------------------------------------------
//1.)Default ctor, runs on first game run, creates base values.
char_player_stats::char_player_stats()
{
	//We need to collect information from the player so we can 
	//build their base stats.
}
//-----------------------------------------------------------------
//-----------------------------------------------------------------
//						BASE STATS MUTATORS
//-----------------------------------------------------------------
//1.)Start_Stats generates the player's level stats.
void char_player_stats::start_stats()
{
	//A.)Gathering Bio Information.
	//--------------------------------------------------------------
	//1.)Character's Age:
	{
		const int AGE_SIZE = 9;
		std::string age_group[AGE_SIZE] = { "Late Teens", "Early 20s", "Late 20s", "Early 30s", "Late 30s", "Early 40s", "Late 40s", "50s", "60s" };
		std::cout << "What age group was your character during the start of the outbreak?" << std::endl;
		std::cout << "Categories:" << std::endl;
		for (int age_index = 1; age_index < (AGE_SIZE + 1); ++age_index)
		{
			std::cout << "[" << age_index << "]: " << age_group[age_index] << std::endl;
		}
		std::cout << "Please enter the number to your desired age group: ";
		int tmp_category;
		std::cin >> tmp_category; std::cout << std::endl;
		std::cin.clear();
		bool age_check = false;
		int base_age, range;
		while (age_check == false)
		{
			switch (tmp_category)
			{
			case 1:
				base_age = 17;
				range = 2;
				age_check == true;
				break;
			case 2:
				base_age = 20;
				range = 5;
				age_check == true;
				break;
			case 3:
				base_age = 25;
				range = 4;
				age_check == true;
				break;
			case 4:
				base_age = 30;
				range = 5;
				age_check == true;
				break;
			case 5:
				base_age = 35;
				range = 4;
				age_check == true;
				break;
			case 6:
				base_age = 40;
				range = 5;
				age_check == true;
				break;
			case 7:
				base_age = 45;
				range = 4;
				age_check == true;
				break;
			case 8:
				base_age = 50;
				range = 9;
				age_check == true;
				break;
			case 9:
				base_age = 60;
				range = 9;
				age_check == true;
				break;
			default:
				std::cout << "Error: You entered an invalid category number, please select a number from 1 through 9: ";
				std::cin >> tmp_category; std::cout << std::endl;
				std::cin.clear();
				break;
			}
		}
		char_age = (base_age + (rand() % range));
	}
	//--------------------------------------------------------------
	{
		//2.)Gather the Player's Gender
		const int GENDER_SIZE = 3;
		std::string gender_selection[GENDER_SIZE] = { "Male", "Female", "Non-Binary" };
		std::cout << "What Gender are you?: " << std::endl;
		std::cout << "Categories: " << std::endl;
		for (int gender_index = 1; gender_index < (GENDER_SIZE + 1); ++gender_index)
		{
			std::cout << "[" << gender_index << "]: " << gender_selection[gender_index] << std::endl;
		}
		std::cout << "Please enter the number to your desired age group: ";
		int tmp_category;
		std::cin >> tmp_category; std::cout << std::endl;
		std::cin.clear();
		bool gender_check = false;
		while (gender_check == false)
		{
			switch (tmp_category)
			{
			case 1:
				char_gender = "Male";
				gender_check = true;
				break;
			case 2:
				char_gender = "Female";
				gender_check = true;
				break;
			case 3:
				char_gender = "Non-Binary";
				gender_check = true;
				break;
			default:
				std::cout << "Error: You entered an invalid category number, please select a number from 1 through 3: ";
				std::cin >> tmp_category; std::cout << std::endl;
				std::cin.clear();
				break;
			}
		}
		//--------------------------------------------------------------
		{

		}
	}
}
//-----------------------------------------------------------------

//================================================================
//				++END CHAR_PLAYER_STATS CLASS++
//================================================================