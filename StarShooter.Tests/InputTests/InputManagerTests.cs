﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarShooter.Input.InputManager;
using StarShooter.Input.Interfaces;
using Moq;
using StarShooter.Input.Enums;
using UnityEngine;

namespace StarShooter.Tests.InputTests
{    

    [TestClass]
    public class InputManagerTests
    {
        private const int TestKeyID = 1;
        private const KeyCode TestKeyCode = KeyCode.A;
        private InputManager manager;
        private Mock<INativeInput> nativeInputMock;

        [TestInitialize]
        public void Setup()
        {
            var inputSettingsMock = new Mock<IInputSettings>();
            inputSettingsMock.Setup(m => m.GetControl(TestKeyCode)).Returns(TestKeyID);
            inputSettingsMock.Setup(m => m.GetKeys()).Returns(new[] { TestKeyCode });


            nativeInputMock = new Mock<INativeInput>();
            SetKeyState(TestKeyCode, KeyState.Down);

            manager = new InputManager(inputSettingsMock.Object, nativeInputMock.Object);
        }

        private void SetKeyState(KeyCode code, KeyState state)
        {
            nativeInputMock.Setup(s => s.GetKeyState(code)).Returns(state);
        }

        [TestMethod]
        public void InputManager_SetKeyState_Setted()
        {
            KeyState keyState = KeyState.Released;
            manager.AddInputListener(TestKeyID, (state) => keyState = state);
            manager.CheckKeys();

            Assert.AreEqual(keyState, KeyState.Down);           
        }

        [TestMethod]
        public void InputManager_StateChange_SettedProperly()
        {
            KeyState keyState = KeyState.Released;            
            manager.AddInputListener(TestKeyID, (state) => keyState = state);

            SetKeyState(TestKeyCode, KeyState.Down);
            manager.CheckKeys();            

            SetKeyState(TestKeyCode, KeyState.Pressed);
            manager.CheckKeys();
            Assert.AreEqual(keyState, KeyState.Pressed);
        }

        [TestMethod]
        public void InputManager_StateChange_CalledOnce()
        {
            int callCount = 0;
            manager.AddInputListener(TestKeyID, (state) => callCount++);

            SetKeyState(TestKeyCode, KeyState.Down);
            manager.CheckKeys();

            SetKeyState(TestKeyCode, KeyState.Down);
            manager.CheckKeys();
            Assert.AreEqual(callCount, TestKeyID);
        }
    }
}