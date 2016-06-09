using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*@Author: Hassan Kobeissi
  @Student#: 300847239
  @Version: 2.0
  @Assignment#: 2
  @Last Modified: June 8rd, 2016.
  @Program Description: Create a SuperHero. 
     */
namespace Hero
{
    /// <summary>
    /// SuperHero extends the Hero Class.
    /// </summary>
    class SuperHero : Hero
    {
        /// <summary>
        /// Private instance variable of type string array
        /// </summary>
        private string[] _superPowers = new string[3];


        #region public string[] SuperPowers
        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }

        }
        #endregion

        #region private string name
        private string name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = "Ultron";
            }
        }
        #endregion

        /// <summary>
        /// Constructor Class. extends to base class Hero.
        /// </summary>
        /// <param name="name"></param>
        #region public SuperHero(string name) : base(name)
        public SuperHero(string name) : base(name)
        {
            _generateRandomPowers();
        }
        #endregion

        /// <summary>
        /// Array of 5 generated superpowers
        /// </summary>
        #region Private Void _generateRandomPowers()
        private void _generateRandomPowers()
        {
            bool duplicatePower = false;
            int powerIndex = 0;
            string[] arrayOfPowers = new string[6];
            arrayOfPowers[0] = "Super Speed";
            arrayOfPowers[1] = "Super Strength";
            arrayOfPowers[2] = "Body Armour";
            arrayOfPowers[3] = "Flight";
            arrayOfPowers[4] = "Fire Generation";
            arrayOfPowers[5] = "Weather Control";

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {               
                do
                {
                    duplicatePower = false;
                    powerIndex = random.Next(0, 6);
                    // loop to check if power already exists
                    for (int index = 0; index < 3; index++)
                    {
                        if (_superPowers[index] == arrayOfPowers[powerIndex])
                        {
                            duplicatePower = true;
                            break;
                        }
                    }
                } while (duplicatePower);


                    this._superPowers[i] = arrayOfPowers[powerIndex];                   
            }  
        }
        #endregion

        /// <summary>
        /// This Public method displays the superPowers array
        ///</summary>
        ///@Returns Void
        #region Public Void ShowPowers()
        public void ShowPowers()
        {
            for (int i = 0; i < _superPowers.Length; i++)
            {
                Console.WriteLine(_superPowers[i]);
            }
        }
        #endregion


    }
}
