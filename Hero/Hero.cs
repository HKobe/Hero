using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @Author Name & StudentNumber: Hassan Kobeissi- 300847239
 * @Last Modified: June 3rd, 2016.
 * @Program Description: Create a Hero. 
 */
namespace Hero
{
    /// <summary>
    /// This is the Hero Class
    /// </summary>
    class Hero
    {
        static Random random = new Random();
        #region Private Instance Variables
       /// <summary>
       /// Private instance variable. Hero's Attributes.
       /// </summary>
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        #endregion

        #region Private Methods (get;set;)


        /// <summary>
        /// This enables the Strength attributes for the hero class
        /// </summary>
        /// @method: Strength
        /// @return: {int}    
        private int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                this._strength = value;
            }

        }
         private int Speed
         {
             get
             {
                 return _speed;
             }
             set
             {
                 this._speed = value;
             }
         }
         private int Health
         {
             get
             {
                 return _health;
             }
             set
             {
                 this._health = value;
             }
         }
         private string Name
         {
             get
             {
                 return _name;
             }
             set
             {
                 this._name = value;
             }
         }
        #endregion

        #region Public Hero(string _name) , _generateAbilities();
        /// <summary>
        /// Constructor Method, calls generate abilities and passes name value.
        /// </summary>
        /// <param name="_name">Hero name</param>
        public Hero(string _name)
        {
            _generateAbilities();
            this.Name = _name;
        }


        /// <summary>
        /// Generates random ability numbers..
        /// </summary>
        private void _generateAbilities()
        {
            Random random = new Random();
            this._strength = random.Next(1, 100);
            this._health = random.Next(1, 100);
            this._speed = random.Next(1, 100);
        }
        #endregion

        #region Public void Fight()
        /// <summary>
        /// Public Fight Method displays the attacks hit/missed 
        /// </summary>
        /// @returns: {void}
        public void Fight()
        {
            if (_hitAttempt() == true)
            {
                Console.WriteLine(_hitDamage());
            }
            else
            {
                Console.WriteLine("Missed!");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int _hitDamage()
        {
            int damage = random.Next(1, 6);
            damage = damage * _strength;
            return damage;
        }
        private bool _hitAttempt()
        {
            int hit;
            hit = random.Next(1, 5);
            if (hit == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region public void Show()
        /// <summary>
        /// Public Method that displays Hero's stats.
        /// </summary>
        /// @Returns: {void}
        /// @Params: None
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Fighting Ability Chart");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" HP       STR     SPEED");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" {0,2}      {1,3}      {2,2}   ", this._health, this._strength, this._speed);
            Console.WriteLine(" -         -       -   ");
            Console.WriteLine(" -         -       -   ");
        }
        #endregion

        #region public void BeginFight() 
        /// <summary>
        /// Public method, Displays BeginFight prompt.
        /// </summary>
        /// @Returns: Void
        /// @Params: None
        public void BeginFight()
        {
            Console.WriteLine(this._name + " Enters, Begin Fight!");
        }
        #endregion
    }

}