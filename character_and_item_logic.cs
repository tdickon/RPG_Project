using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_and_item_logic
{

    //=======================================================================================================================================
    //
    //========================================================================================================================================
    public class character
    {
        protected personal_information character_info;
        protected level_system character_level;
        protected social_stat_attributes character_social_attributes;

        //Constructors
        protected character()
        {
            character_info = new personal_information();
            character_level = new level_system();
            character_social_attributes = new social_stat_attributes();
            return;
        }
        protected character(personal_information char_info, level_system char_lvl, social_stat_attributes char_social_attributes)
        {
            character_info = char_info;
            character_level = char_lvl;
            character_social_attributes = char_social_attributes;
            return;
        }
        protected character(character char_copy_from)
        {
            this.character_info = char_copy_from.character_info;
            this.character_level = char_copy_from.character_level;
            this.character_social_attributes = char_copy_from.character_social_attributes;
            return;
        }

        //set functions
        public void set_character_info(personal_information char_info)
        {
            character_info = char_info;
            return;
        }
        public void set_character_level(level_system char_lvl_system)
        {
            character_level = char_lvl_system;
            return;
        }
        public void set_social_attributes(social_stat_attributes social_attributes)
        {
            character_social_attributes = social_attributes;
            return;
        }
        
        //Return Functions
        public personal_information return_character_info()
        {
            return character_info;
        }
        public level_system return_character_level()
        {
            return character_level;
        }
        public social_stat_attributes return_character_social_attributes()
        {
            return character_social_attributes;
        }
    }
    public class super : character
    {
        protected super_information character_super_info;
        protected base_combat_attributes character_base_combat_attributes;
        protected derived_stats character_derived_stats;
        protected armor_stats character_active_armor;
        //Constructors

    }

    public class player_character : super
    {

    }


    //=======================================================================================================================================
    //Base Character Classes -- These are the base stats for our characters
    //=======================================================================================================================================
    public class base_combat_attributes  //Class that holds data about a character's base combat stats 
    {
        //Private Stat Variables
        private int super_strength; //Determines the strength of your melee combat abilities, your ability to pick up large objects or other scenarios in which your strength would need to be checked.  
        private int super_speed; //Determines the rate at which you are able to attack or checks in which speed should be accounted.
        private int super_vitality; //Vitality determines your health points that you have on your character. This can test your stamina or endurance based roll checks. 
        private int super_reflexes; //Determines your ability to do ranged based combat, or where your reflexes would need to be tested. 

        //Constructors
        public base_combat_attributes()
        {
            set_baseCombat_stat_value(0, "strength");
            set_baseCombat_stat_value(0, "speed");
            set_baseCombat_stat_value(0, "vitality");
            set_baseCombat_stat_value(0, "reflexes");
            return;
        }
        public base_combat_attributes(int str, int spd, int vit, int reflex)
        {
            set_baseCombat_stat_value(str, "strength");
            set_baseCombat_stat_value(spd, "speed");
            set_baseCombat_stat_value(vit, "vitality");
            set_baseCombat_stat_value(reflex, "reflexes");
            return;
        }
        public base_combat_attributes(base_combat_attributes stats_to_copy_from)
        {
            set_baseCombat_stat_value(stats_to_copy_from.return_baseCombat_stat_value("strength"), "strength");
            set_baseCombat_stat_value(stats_to_copy_from.return_baseCombat_stat_value("speed"), "speed");
            set_baseCombat_stat_value(stats_to_copy_from.return_baseCombat_stat_value("vitality"), "vitality");
            set_baseCombat_stat_value(stats_to_copy_from.return_baseCombat_stat_value("reflexes"), "reflexes");
            return;
        }

        //Functionality
        public int return_baseCombat_stat_value(string stat_to_return) //This is a function that returns a character's power stats. 
        {
            int value_to_return = 0;

            switch (stat_to_return)
            {
                case "strength":
                    value_to_return = super_strength;
                    break;
                case "speed":
                    value_to_return = super_speed;
                    break;
                case "vitality":
                    value_to_return = super_vitality;
                    break;
                case "reflexes":
                    value_to_return = super_reflexes;
                    break;
            }
            return value_to_return;
        }
        public void set_baseCombat_stat_value(int value,string stat_to_return) //This is a function that returns a character's power stats. 
        {
            misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
            switch (stat_to_return)
            {
                case "strength":
                    super_strength = tool_kit.set_int_value(value);
                    break;
                case "speed":
                    super_speed = tool_kit.set_int_value(value);
                    break;
                case "vitality":
                    super_vitality = tool_kit.set_int_value(value);
                    break;
                case "reflexes":
                    super_reflexes = tool_kit.set_int_value(value);
                    break;
            }
            return;
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class social_stat_attributes //Class that holds data about a character's social stats. 
    {
        //private variables for our social stats.
        private int street_smarts; //Helps roll for things that deal with street activity, criminal activity, and low level police work.
        private int education_level; //Helps roll for things dealing with politics, history, influincing educated people, or asking critical questions.
        private int charisma; //Helps you influence, persuade, or joke with others in a seductive way 
        private int tech_knowledge; //Helps you with rolling on tech problems, or computer based things. 
        private int science_knowledge; //Helps you when dealing with scientific problems, or solving scientific things like a cure, virus, etc. 
        private int mystical_knowledge; //You understand the history and are familiar with the work of witches and magicians, and mystical realms. 
        private int cosmic_knowledge; //Knowledge on how space and it's depths are. 

        //Constructors
        public social_stat_attributes()
        {
            set_social_stat_values(0, "street_smarts");
            set_social_stat_values(0, "education_level");
            set_social_stat_values(0, "charisma");
            set_social_stat_values(0, "tech");
            set_social_stat_values(0, "science");
            set_social_stat_values(0, "mystical");
            set_social_stat_values(0, "cosmic");
            return;
        }
        public social_stat_attributes(int ss, int el, int charm, int tech, int sci, int myst, int cosmic)
        {
            set_social_stat_values(ss, "street_smarts");
            set_social_stat_values(el, "education_level");
            set_social_stat_values(charm, "charisma");
            set_social_stat_values(tech, "tech");
            set_social_stat_values(sci, "science");
            set_social_stat_values(myst, "mystical");
            set_social_stat_values(cosmic, "cosmic");
            return;
        }
        public social_stat_attributes(social_stat_attributes stats_to_copy_from)
        {
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("street_smarts"), "street_smarts");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("education_level"), "education_level");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("charisma"), "charisma");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("tech"), "tech");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("science"), "science");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("mystical"), "mystical");
            set_social_stat_values(stats_to_copy_from.return_social_stat_value("cosmic"), "cosmic");
            return;
        }

        //Functionality 
        public int return_social_stat_value(string stat_to_return)
        {
            int value_returned = 0;

            switch (stat_to_return)
            {
                case "street_smarts":
                    value_returned = street_smarts;
                    break;
                case "education_level":
                    value_returned = education_level;
                    break;
                case "charisma":
                    value_returned = charisma;
                    break;
                case "tech":
                    value_returned = tech_knowledge;
                    break;
                case "science":
                    value_returned = science_knowledge;
                    break;
                case "mystical":
                    value_returned = mystical_knowledge;
                    break;
                case "cosmic":
                    value_returned = cosmic_knowledge;
                    break;
            }

            return value_returned;
        }
        public void set_social_stat_values(int value, string stat_to_set)
        {
          misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
          switch (stat_to_set)
          {
           case "street_smarts":
                street_smarts = tool_kit.set_int_value(value);
                break;
           case "education_level":
                education_level = tool_kit.set_int_value(value);
                break;
           case "charisma":
                charisma = tool_kit.set_int_value(value);
                break;
           case "tech":
                tech_knowledge = tool_kit.set_int_value(value);
                break;
           case "science":
                science_knowledge = tool_kit.set_int_value(value);
                break;
           case "mystical":
                mystical_knowledge = tool_kit.set_int_value(value);
                break;
           case "cosmic":
                cosmic_knowledge = tool_kit.set_int_value(value);
                break;
          }
          return;
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class personal_information
    {
        private string character_name;
        private string sex; //possible class eventually?
        private string occupation; //possible class

        public personal_information()
        {
            character_name = "";
            sex = "";
            occupation = "";
        }
        public personal_information(string char_name, string char_sex, string job)
        {
            character_name = char_name;
            sex = char_sex;
            occupation = job;
        }
        public personal_information(personal_information data_to_copy)
        {
            this.character_name = data_to_copy.character_name;
            this.sex = data_to_copy.sex;
            this.occupation = data_to_copy.occupation;
        }

        //Return functions
        public string return_character_name()
        {
            return character_name;
        }
        public string return_char_sex()
        {
            return sex;
        }
        public string return_char_occupation()
        {
            return occupation;
        }

        //Set Functions 
        public void set_character_name(string name)
        {
            character_name = name;
            return;
        }
        public void set_character_sex(string gender)
        {
            sex = gender;
            return;
        }
        public void set_character_occupation(string job)
        {
            occupation = job;
            return;
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class super_information
    {
        private string super_name;
        private int hero_reputation; //Negative shows a villain - Positive shows a hero
        private power_type super_power; 
        //class about character reputation / status 
        //class about character type - which holds their abilities
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class level_system
    {
        //Static Variables, global to all characters.
        private static int[] LEVEL_CHART = { 100, 500, 1000, 5000, 10000, 15000, 30000, 50000, 100000, 150000 }; //Notifies the current experience requirements to go to the next level;

        //Private Variables - Unique per character
        private int current_level;
        private int current_exp;
        private bool max_level;

        //Constructors
        public level_system()
        {
            set_current_level(0);
            init_current_exp(0);
            set_max_level(false);
            return;
        }
        public level_system(int lvl, int xp, bool max_lvl)
        {
            set_current_level(lvl);
            init_current_exp(xp);
            set_max_level(max_lvl);
            return;
        }
        public level_system(level_system copy)
        {
            set_current_level(copy.return_current_level());
            set_current_exp(copy.return_current_exp());
            set_max_level(copy.return_max_level_stat());
            return;
        }

        //Init Functions
        private void init_current_exp(int xp)
        {
            misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
            current_exp = tool_kit.set_int_value(xp);
            return;
        }
        //Return functions 
        public int return_current_level()
        {
            return current_level;
        }
        public int return_current_exp()
        {
            return current_exp;
        }
        public bool return_max_level_stat()
        {
            return max_level;
        }
        //Set functions
        public void set_current_level(int lvl)
        {
            misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
            current_level = tool_kit.set_int_value(lvl);
            return;
        }
        public void set_current_exp(int xp)
        {
            if(xp < 0) { return; }
            else
            {
                current_exp += xp;
                return;
            }
        }
        public void set_max_level(bool max_lvl)
        {
            max_level = max_lvl;
            return;
        }

        public void level_up_check() //If Max_Level == True -> nothing. Else If: Current_XP >= Level Req -> reset current xp = Current_XP - Level Req, then ++Level, finally return.
        {
            if (max_level == false)
            {
                int current_level_exp_req = LEVEL_CHART[current_level - 1];
                //If our exp is larger than the current_level_requirement then we will level up our character. 
                if (current_exp >= current_level_exp_req)
                {
                    if ((current_level + 1) == 10)
                    {
                        ++current_level;
                        max_level = true;
                        return;
                    }
                    else
                    {
                        current_exp = current_exp - current_level_exp_req;
                        ++current_level;
                        return;
                    }
                }
            }
            else { return; }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    //=======================================================================================================================================
    //Derived Stats Class and Subset Classes -- These are volatile classes 
    //=======================================================================================================================================
    public class derived_stats //Derived stats hold the volatile data that is dependent upon the current combat situation as well as the character's build.
    {
        private health_stats character_health_data;
        private attack_speed_stats character_attack_speed_data;
        private melee_damage_stats character_melee_dmg_data;
        private range_damage_stats character_range_dmg_data;
        //Constructors
        public derived_stats()
        {
            character_health_data = new health_stats();
            character_attack_speed_data = new attack_speed_stats();
            character_melee_dmg_data = new melee_damage_stats();
            character_range_dmg_data = new range_damage_stats();
        }
        public derived_stats(health_stats char_health_data, attack_speed_stats attk_speed_data, melee_damage_stats melee_dmg_data, range_damage_stats range_dmg_data)
        {
            character_health_data = char_health_data;
            character_attack_speed_data = attk_speed_data;
            character_melee_dmg_data = melee_dmg_data;
            character_range_dmg_data = range_dmg_data;
        }
        public derived_stats(derived_stats stats_to_copy)
        {
            this.character_health_data = stats_to_copy.character_health_data;
            this.character_attack_speed_data = stats_to_copy.character_attack_speed_data;
            this.character_melee_dmg_data = stats_to_copy.character_melee_dmg_data;
            this.character_range_dmg_data = stats_to_copy.character_range_dmg_data;
        }

        //return functions
        public int return_total_health()
        {
            return character_health_data.return_total_health();
        }
        public int return_current_health()
        {
            return character_health_data.return_current_health();
        }
        public int return_base_attack_speed()
        {
            return character_attack_speed_data.return_base_attack_speed();
        }
        public int return_current_attack_speed()
        {
            return character_attack_speed_data.return_current_attack_speed();
        }
        public int return_character_dmg_value(string dmg_type, string min_or_max) // "melee" for melee values "range" for range -- "max" if you want the max dmg, "min" if you want the minimum damage
        {
            int return_value = 0;
            switch (dmg_type)
            {
                case "melee":
                    if (min_or_max == "min") { return_value = character_melee_dmg_data.return_min_melee_damage(); }
                    else { return_value = character_melee_dmg_data.return_max_melee_damage(); }
                    break;
                case "range":
                    if (min_or_max == "min") { return_value = character_range_dmg_data.return_min_ranged_damage(); }
                    else { return_value = character_range_dmg_data.return_max_ranged_damage(); }
                    break;
            }
            return return_value;
        }
        public double return_crit_chance(string dmg_type) //"melee" for melee value, "range" for range value
        {
            double return_value = 0;
            switch (dmg_type)
            {
                case "melee":
                    return_value = character_melee_dmg_data.return_crit_chance();
                    break;
                case "range":
                    return_value = character_range_dmg_data.return_ranged_crit_damage();
                    break;
            }
            return return_value;
        }
        //set functions
        public void set_total_health(int health_to_set_to)
        {
            character_health_data.set_total_health(health_to_set_to);
            return;
        }
        public void set_current_health(int health_to_set_to, string value_type)
        {
            character_health_data.set_current_health_points(health_to_set_to, value_type);
            return;
        }
        public void set_base_attack_speed(int attk_speed_to_set_to)
        {
            character_attack_speed_data.set_base_attack_speed(attk_speed_to_set_to);
            return;
        }
        public void set_current_attack_speed(int attk_speed_to_set_to)
        {
            character_attack_speed_data.set_current_attack_speed(attk_speed_to_set_to);
            return;
        }
        public void set_character_int_dmg_value(int value, string dmg_type, string min_or_max) //"melee" for melee values, "range" for range values. -- "max" if you want the max dmg, "min" for min. 
        {
            switch (dmg_type)
            {
                case "melee":
                    if (min_or_max == "min") { character_melee_dmg_data.set_min_melee_damage(value); }
                    else { character_melee_dmg_data.set_max_melee_damage(value); }
                    break;
                case "range":
                    if (min_or_max == "min") { character_range_dmg_data.set_min_ranged_damage(value); }
                    else { character_range_dmg_data.set_max_ranged_damage(value); }
                    break;
            }
            return;
        }
        public void set_character_crit_value(double value, string dmg_type) //"melee" for melee value, "range" for range_values
        {
            switch (dmg_type)
            {
                case "melee":
                    character_melee_dmg_data.set_crit_chance(value);
                    break;
                case "range":
                    character_range_dmg_data.set_ranged_crit_chance(value);
                    break;
            }
            return;
        }

    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    //Subset of the Dervied Stats -- Vary based on the character's base_combat and social_stats.
    public class health_stats //Health info, effected by Vitality and Damage or Health Modifiers 
    {
        private int total_health_points;
        private int current_health_points;
        public bool alive_status;

        //Constructors
        public health_stats()
        {
            total_health_points = 0;
            current_health_points = 0;
            alive_status = true;
        }
        public health_stats(int total_health, int current_hp)
        {
            total_health_points = total_health;
            current_health_points = current_hp;
            alive_status = true;
        }

        //Set Functions
        public void set_total_health(int value_set_to)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            total_health_points = toolkit.set_int_value(value_set_to);
            return;
        }
        public void set_current_health_points(int hp_change, string type_of_change)
        {
            int new_hp_value = 0;
            switch (type_of_change)
            {
                //Taking Damage
                case "subtract_health":
                    new_hp_value = current_health_points - hp_change;
                    damage_controller(new_hp_value);
                    break;
                //Gaining Health
                case "add_health":
                    new_hp_value = current_health_points + hp_change;
                    health_gain_controller(new_hp_value);
                    break;
            }
            return;
        }

        //Private Functions that are used within our set hp_values
        private void damage_controller(int hp_value)
        {
            bool dead_status = check_if_dead(hp_value);
            if (dead_status == true)
            {
                current_health_points = 0;
                alive_status = false;
                return;
            }
            else
            {
                current_health_points = hp_value;
                return;
            }
        }
        private bool check_if_dead(int hp_value)
        {
            if (hp_value > 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        private void health_gain_controller(int hp_value)
        {
            //Check to see if our health gain was larger than our total_health_pool
            if (hp_value > total_health_points)
            {
                int value_over = hp_value - total_health_points;
                hp_value -= value_over;
                current_health_points = hp_value;
                return;
            }

            else
            {
                current_health_points += hp_value;
            }
        }

        //Return Functions
        public int return_total_health()
        {
            return total_health_points;
        }
        public int return_current_health()
        {
            return current_health_points;
        }

    }
    //------------------------------------------------------------------------------------------------------------------------------------
    public class attack_speed_stats //Attack Speed, effected by SuperSpeed, and Armor speed reductions
    {
        private int base_attack_speed;
        private int current_attack_speed;

        //Constructors
        public attack_speed_stats()
        {
            set_base_attack_speed(0);
            set_current_attack_speed(0);
            return;
        }
        public attack_speed_stats(int base_attk_spd, int current_attk_spd)
        {
            set_base_attack_speed(base_attk_spd);
            set_current_attack_speed(current_attk_spd);
            return;
        }
        public attack_speed_stats(attack_speed_stats stats_to_copy)
        {
            set_base_attack_speed(stats_to_copy.return_base_attack_speed());
            set_current_attack_speed(stats_to_copy.return_current_attack_speed());
            return;
        }

        //Set Functions
        public void set_base_attack_speed(int base_attk_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            base_attack_speed = toolkit.set_int_value(base_attk_value);
            return;
        }
        public void set_current_attack_speed(int speed_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            current_attack_speed = toolkit.set_int_value(speed_value);
            return;
        }

        //Return functions
        public int return_base_attack_speed()
        {
            return base_attack_speed;
        }
        public int return_current_attack_speed()
        {
            return current_attack_speed;
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------
    public class melee_damage_stats //Based off a char's super-strength, can be upped by buff or debuffs. 
    {
        //Private Data Variables
        private int min_melee_damage;
        private int max_melee_damage;
        private double crit_chance_percent;

        //Constructors
        public melee_damage_stats()
        {
            set_min_melee_damage(0);
            set_max_melee_damage(0);
            set_crit_chance(0);
            return;
        }
        public melee_damage_stats(int min, int max, double crit_chance)
        {
            set_min_melee_damage(min);
            set_max_melee_damage(max);
            set_crit_chance(crit_chance);
            return;
        }
        public melee_damage_stats(melee_damage_stats stats_to_copy)
        {
            set_min_melee_damage(stats_to_copy.return_min_melee_damage());
            set_max_melee_damage(stats_to_copy.return_max_melee_damage());
            set_crit_chance(stats_to_copy.return_crit_chance());
            return;
        }

        //Return functions
        public int return_min_melee_damage()
        {
            return min_melee_damage;
        }
        public int return_max_melee_damage()
        {
            return max_melee_damage;
        }
        public double return_crit_chance()
        {
            return crit_chance_percent;
        }

        //Set Functions
        public void set_min_melee_damage(int dmg_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            min_melee_damage = toolkit.set_int_value(dmg_value);
            return;
        }
        public void set_max_melee_damage(int dmg_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            max_melee_damage = toolkit.set_int_value(dmg_value);
            return;
        }
        public void set_crit_chance(double crit_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            crit_chance_percent = toolkit.set_double_value(crit_value);
            return;
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------
    public class range_damage_stats //Based of a char's super-reflexes, can be + or - by buffs or debuffs
    {
        private int min_ranged_damage;
        private int max_ranged_damage;
        private double ranged_crit_chance_percentage;

        //Constructors
        public range_damage_stats()
        {
            set_min_ranged_damage(0);
            set_max_ranged_damage(0);
            set_ranged_crit_chance(0);
            return;
        }
        public range_damage_stats(int max, int min, double crit_chance)
        {
            set_min_ranged_damage(min);
            set_max_ranged_damage(max);
            set_ranged_crit_chance(crit_chance);
            return;
        }
        public range_damage_stats(range_damage_stats stats_to_copy)
        {
            set_min_ranged_damage(stats_to_copy.return_min_ranged_damage());
            set_max_ranged_damage(stats_to_copy.return_max_ranged_damage());
            set_ranged_crit_chance(stats_to_copy.return_ranged_crit_damage());
            return;
        }

        //Return functions
        public int return_min_ranged_damage()
        {
            return min_ranged_damage;
        }
        public int return_max_ranged_damage()
        {
            return max_ranged_damage;
        }
        public double return_ranged_crit_damage()
        {
            return ranged_crit_chance_percentage;
        }

        //Set functions
        public void set_min_ranged_damage(int r_dmg_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            min_ranged_damage = toolkit.set_int_value(r_dmg_value);
            return;
        }
        public void set_max_ranged_damage(int r_dmg_value)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            max_ranged_damage = toolkit.set_int_value(r_dmg_value);
            return;
        }
        public void set_ranged_crit_chance(double crit_chance)
        {
            misc_character_and_item_logic_funcs toolkit = new misc_character_and_item_logic_funcs();
            ranged_crit_chance_percentage = toolkit.set_double_value(crit_chance);
            return;
        }
    }
    //=======================================================================================================================================
    //Item Classes -- These classes are distinct objects that can be used by a character, and will have effects on character's derived stats.
    //=======================================================================================================================================
    public class armor_stats //Class that deals with holding armor meta_data 
    {
        private string armor_name;
        private int armor_rating;
        private int speed_reduction;

        //Constructors
        public armor_stats()
        {
            set_armor_name("");
            set_armor_rating(0);
            set_speed_reduction(0);
            return;
        }
        public armor_stats(string name, int rating, int reduction)
        {
            set_armor_name(name);
            set_armor_rating(rating);
            set_speed_reduction(reduction);
            return;
        }
        public armor_stats(armor_stats stats_to_copy)
        {
            set_armor_name(stats_to_copy.return_armor_name());
            set_armor_rating(stats_to_copy.return_armor_rating());
            set_speed_reduction(stats_to_copy.return_armor_speed_reduction());
            return;
        }

        //Return functions
        public int return_armor_rating()
        {
            return armor_rating;
        }
        public string return_armor_name()
        {
            return armor_name;
        }
        public int return_armor_speed_reduction()
        {
            return speed_reduction;
        }

        //Set Functions 
        public void set_armor_rating(int rate_to_set_to)
        {
            misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
            armor_rating = tool_kit.set_int_value(rate_to_set_to);
            return;
        }
        public void set_speed_reduction(int speed_to_set_to)
        {
            misc_character_and_item_logic_funcs tool_kit = new misc_character_and_item_logic_funcs();
            speed_reduction = tool_kit.set_int_value(speed_to_set_to);
            return;
        }
        public void set_armor_name(string string_name)
        {
            armor_name = string_name;
            return;
        }


    }
    //--------------------------------------------------------------------------------------------------------------------------------------
    //=======================================================================================================================================
    //EXTENSION CLASSES - Classes that help flesh out functionality for our character classes. 
    //=======================================================================================================================================
    public class derived_stats_functionality //SUBJECT TO CHANGE
    {
        //Character creation formulas:
        public int set_starting_stats_formula(int base_stat)
        {
            int stat_to_return = base_stat * 2;
            return stat_to_return;
        }
        public void setting_starting_derived_stats(derived_stats stats_to_set, base_combat_attributes base_stats_to_ref)
        {
            //Setting up our initial speed stats.
            stats_to_set.set_base_attack_speed(set_starting_stats_formula(base_stats_to_ref.return_baseCombat_stat_value("speed")));
            stats_to_set.set_current_attack_speed(stats_to_set.return_base_attack_speed());

            //Setting up our initial helath stats. 
            stats_to_set.set_total_health(set_starting_stats_formula(base_stats_to_ref.return_baseCombat_stat_value("vitality")));
            stats_to_set.set_current_health(stats_to_set.return_total_health(), "add_health");
            //Setting up our initial melee damage stats. 
            stats_to_set.set_character_int_dmg_value(base_stats_to_ref.return_baseCombat_stat_value("strength"), "melee", "max");
            stats_to_set.set_character_int_dmg_value(find_min_dmg_value(stats_to_set.return_character_dmg_value("melee", "max")), "melee", "min");
            stats_to_set.set_character_crit_value(STARTING_CRIT_CHANCE, "melee");

            //Setting up our initial ranged damage stats.
            stats_to_set.set_character_int_dmg_value(base_stats_to_ref.return_baseCombat_stat_value("reflexes"), "range", "max");
            stats_to_set.set_character_int_dmg_value(find_min_dmg_value(stats_to_set.return_character_dmg_value("range", "max")), "range", "min");
            stats_to_set.set_character_crit_value(STARTING_CRIT_CHANCE, "min");
            return;
        }
        //Dervied Stat Formulas:
        public int attack_speed_formula(int base_attack_speed, int armor_speed_reduction)
        {
            int reduction_cost = armor_speed_reduction / 10;
            int attk_speed_returned = base_attack_speed - reduction_cost;
            return attk_speed_returned;
        }
        public int level_up_health_change(int current_total_health, int char_vitality)
        {
            int health_bonus_to_add = char_vitality / 10;
            int total_health_returned = current_total_health + health_bonus_to_add;
            return total_health_returned;
        }
        public int find_min_dmg_value(int max_value)
        {
            return max_value - 5;
        }
        static public double STARTING_CRIT_CHANCE = 0.1;
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class misc_character_and_item_logic_funcs
    {
        public int set_int_value(int input_value)
        {
            if (input_value < 0) { return 0; }
            else { return input_value; }
        }
        public double set_double_value(double input_value)
        {
            if (input_value < 0) { return 0; }
            else { return input_value; }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------
    //=======================================================================================================================================
    //POWER TYPES
    //=======================================================================================================================================
    //1.) Normal - 2.) Toxin  - 3.) Fire - 4.)Ice/Snow - 5.) Water - 6.) Mineral - 7.)Mineral/Rock - 8.) Water - 9.)Nature - 10.) Metal
    //12.) Electric - 13.)Telpathic - 14.) Magical - 15.)Underworld - 16.)Celestial - 17.) Atomic - 18.) Supernatural
    //---------------------------------------------------------------------------------------------------------------------------------------
    public class power_type
    {
        private string name;
        private power_type_dmg_ref[] power_dmg_ref_list;

        public power_type()
        {
            name = "";
        }
        public power_type(string pwr_name, power_type_dmg_ref[] ref_array)
        {
            set_power_name(pwr_name);
            set_power_ref_list(ref_array);
            return;
        }
        public power_type(power_type copy_from)
        {
            set_power_name(copy_from.return_name());
            this.power_dmg_ref_list = copy_from.power_dmg_ref_list;
            return;
        }
        //Return Functions
        protected string return_name()
        {
            return name;
        }
        protected power_type_dmg_ref return_power_ref(string name_needed)
        {
            power_type_dmg_ref return_value = new power_type_dmg_ref();

            int array_length = power_dmg_ref_list.Length;

            for (int index = 0; index < array_length; ++index)
            {
                if (name_needed == power_dmg_ref_list[index].return_power_name())
                {
                    return_value = power_dmg_ref_list[index];
                    break;
                }

                else { continue; }
            }
            return return_value;
        }

        //Set Functions
        public void set_power_name(string pwr_name)
        {
            name = pwr_name;
        }
        public void set_power_ref_list(power_type_dmg_ref[] ref_sheet)
        {
            power_dmg_ref_list = ref_sheet;
            return;
        }

    }
    public class power_type_dmg_ref //Power type will hold a name of a power, the damage that that power does against someone with a normal power, 
    {
        private string power_name;
        private double dmg_value_against_power;

        public power_type_dmg_ref()
        {
            power_name = "";
            dmg_value_against_power = 0;
        }
        public power_type_dmg_ref(string name, double dmg_value)
        {
            power_name = name;
            dmg_value_against_power = dmg_value;
        }
        public power_type_dmg_ref(power_type_dmg_ref copy)
        {
            power_name = copy.power_name;
            dmg_value_against_power = copy.dmg_value_against_power;
        }

        public string return_power_name()
        {
            return power_name;
        }
        public double return_dmg_value()
        {
            return dmg_value_against_power;
        }
    }
    public class power_type_extensions
    {
        public static string[] power_names_list = { "Vigilante", "Toxin", "Fire", "Ice", "Water", "Mineral", "Nature",
                                                    "Metal", "Electric", "Telepathic", "Magical", "Supernatural", "Celestial", "Cybernetic","Atomic"};
        public power_type set_power_type(string type)
        {
            power_type temp = new power_type();
            switch (type)
            {
                case "Vigilante":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(vigilante_set_up());
                    break;
                case "Toxin":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(toxin_set_up());
                    break;
                case "Fire":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(fire_set_up());
                    break;
                case "Ice":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(ice_set_up());
                    break;
                case "Water":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(water_set_up());
                    break;
                case "Mineral":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(mineral_set_up());
                    break;
                case "Nature":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(nature_set_up());
                    break;
                case "Metal":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(metal_set_up());
                    break;
                case "Electric":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(electric_set_up());
                    break;
                case "Telepathic":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(telepathic_set_up());
                    break;
                case "Magical":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(magical_set_up());
                    break;
                case "Supernatural":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(supernatural_set_up());
                    break;
                case "Celestial":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(celestial_set_up());
                    break;
                case "Cybernetic":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(cybernetic_set_up());
                    break;
                case "Atomic":
                    temp.set_power_name(type);
                    temp.set_power_ref_list(atomic_set_up());
                    break;
            }
            return temp;
        }

        //These are functions that will help us build our damage refrence sheets. 
        private power_type_dmg_ref[] vigilante_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] toxin_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] fire_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] ice_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] water_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] mineral_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] nature_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] metal_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] electric_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] telepathic_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] magical_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] supernatural_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] celestial_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] cybernetic_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 1);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 0.5);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
        private power_type_dmg_ref[] atomic_set_up()
        {
            int names_list_len = power_names_list.Length;
            power_type_dmg_ref[] return_list = new power_type_dmg_ref[names_list_len];
            for (int index = 0; index < names_list_len; ++index)
            {
                switch (index)
                {
                    case 0: //Vigilante
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 1: //Toxin
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 2: //Fire
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }

                    case 3: //Ice
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 4: //Water
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 5: //Mineral
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 6: //Nature
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 7: //Metal
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 8: //Electric
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 9: //Telepathic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 10: //Magical
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 11: //Supernatural
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 12: //Celestial
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 13: //Cybernetic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                    case 14: //Atomic
                        {
                            power_type_dmg_ref temp = new power_type_dmg_ref(power_names_list[index], 2);
                            return_list[index] = temp;
                            break;
                        }
                }
            }
            return return_list;
        }
    }
}
