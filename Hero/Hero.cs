using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class Hero
    {
        #region Private Instance Variables
        /*Hero's attributes*/
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        #endregion

        #region Public Methods
        /*
         * <summary>
         * This methods enables the Strength attribute for the Hero class 
         * </summary>
         * @method: Strength
         * @return: {int}
         */
        public int Strength
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

        public Hero(string name)
        {
            _generateAbilities();
            this._name = name;
        }

        private void _generateAbilities()
        {
            Random random = new Random();
            this._strength = random.Next(1, 100);
            this._health = random.Next(1, 100);
            this._speed = random.Next(1, 100);
        }

        #region Public Methods
        /*
         * <summary>
         * Public Fight Methods displays the private method _hitAttempt()
         * </summary>
         * @returns: {void}
         */
        public void Fight()
        {
            if (_hitAttempt() == true)
            {
                Console.WriteLine(_hitDamage());
                                        
            }
           
        }
        private int _hitDamage()
        {
            Random random = new Random();
            int damage = random.Next(1, 6);
            damage = damage * _strength;
            return damage;
        }
        private bool _hitAttempt()
        {
            int hit;
            Random random = new Random();
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
        public void Show()
        {
            /*<summary>
            Public method that displays Hero Stats 
            </summary>
            @Returns: {void}
             */
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Fighting Ability Chart");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" HP       STR     SPEED");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" {0,2}      {1,3}      {2,2}   ", this._health, this._strength, this._speed);
            Console.WriteLine(" -         -       -   ");
            Console.WriteLine(" -         -       -   ");
        }
        #endregion

    }
    
}