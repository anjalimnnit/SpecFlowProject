using FluentAssertions;
using GameCharacter;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FirstSpecflowProject.Steps
{
    [Binding]
    public class PlayingAGameSteps
    {
        private Character _character;
        [Given(@": I am a new player")]
        public void GivenIAmANewPlayer()
        {
            _character = new Character(GameCharacter.Type.Elf);
        }


        [When(@"I got hit by (.*)")]
        public void WhenIGotHitBy(int damage)
        {
            _character.Hit(damage);
        }
        
        [Then(@"My health should be (.*)")]
        public void ThenMyHealthShouldBe(int health)
        {
            _character.Health.Should().Be(health);  
        }

        [Given(@": I have the following properties:")]
        public void GivenIHaveTheFollowingProperties(Table table)
        {
            dynamic info= table.CreateDynamicInstance();
            _character = new Character(GameCharacter.Type.Elf) ;
            _character.Wear = info.Wear;
            _character.Spell = Enum.Parse(typeof(Spell),info.Spell);
            

        }
        [When(@"I got hot by (.*)")]
        public void WhenIGotHotBy(int damage)
        {
            _character.Hit(damage);
        }

        [Then(@"My health shoulld be (.*)")]
        public void ThenMyHealthShoulldBe(int health)
        {
            _character.Health.Should().Be(health);
        }

       
        [Given(@"I have the folowing weapons")]
        public void GivenIHaveTheFolowingWeapons(Table table)
        {
            IEnumerable<Weapon> weapons = table.CreateSet<Weapon>();
            foreach(Weapon weapon in weapons)
            {
                _character.Weapons.Add(weapon);
            }
        }

        [When(@"I got robbed on (.*)")]
        public void WhenIGotRobbedOnKnife(string name)
        {
            _character.Steal(name);
        }


        [Then(@"I should have only two weapons")]
        public void ThenIShouldHaveOnlyTwoWeapons()
        {
            _character.Weapons.Count.Should().Be(2);
        }

    }
}
