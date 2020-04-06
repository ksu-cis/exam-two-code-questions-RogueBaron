using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// A event for when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private FruitFilling fruit;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit 
        { 
            get 
            {
                return fruit;
            } 
            set
            {
                fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isPeach"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isCherry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isBlueberry"));
            }
        }

        /// <summary>
        /// idicates if Fruit is peach
        /// </summary>
        public bool isPeach
        {
            get { return Fruit == FruitFilling.Peach; }
            set { Fruit = FruitFilling.Peach; }
        }

        /// <summary>
        /// inidcates if Fruit is cherry
        /// </summary>
        public bool isCherry
        {
            get { return Fruit == FruitFilling.Cherry; }
            set { Fruit = FruitFilling.Cherry; }
        }
        
        /// <summary>
        /// Idicates if Fruit is blueberry
        /// </summary>
        public bool isBlueberry
        {
            get { return Fruit == FruitFilling.Blueberry; }
            set { Fruit = FruitFilling.Blueberry; }
        }

        private bool withIceCream = true;

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream 
        { 
            get { return withIceCream; }
            set 
            {
                withIceCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        
    }
}
