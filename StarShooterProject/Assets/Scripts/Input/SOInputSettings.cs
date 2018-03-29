using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarShooter.GameManagement;
using StarShooter.GameManagement.Data;
using StarShooter.Input.Interfaces;
using UnityEngine;

namespace StarShooter.Unity.Input
{
    [CreateAssetMenu(fileName = "InputSettings", menuName = "Games/Create input settings")]
    public class SOInputSettings : ScriptableObject, IInputSettings
    {


        public KeyCode[] GetKeys()
        {
            throw new NotImplementedException();
        }

        public int GetControl(KeyCode code)
        {
            throw new NotImplementedException();
        }
    }

}
