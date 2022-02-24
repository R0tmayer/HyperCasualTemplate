﻿using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Input
{
    public class InputReceiver : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
    {
        [SerializeField] [Required] private RectTransform _joystick;
        [SerializeField] [Required] private RectTransform _internalJoystick;
        private int? _currentFinger;
        private Vector2 _initPos;

        private float _maxDistance;

        public Vector2 Direction { get; private set; }
        public float DistanceRation { get; private set; }

        private void Awake()
        {
            _maxDistance = _joystick.rect.width / 2f;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.pointerId != _currentFinger) return;
            Vector2 direction = eventData.position - _initPos;
            DistanceRation = Mathf.Clamp01(direction.magnitude / _maxDistance);
            Direction = direction.normalized;
            SetJoystickPosition();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (_currentFinger != null) return;
            ResetJoystickPosition();
            _joystick.position = eventData.position;
            _currentFinger = eventData.pointerId;
            _joystick.gameObject.SetActive(true);
            _initPos = eventData.position;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (_currentFinger != eventData.pointerId) return;
            _currentFinger = null;
            ResetJoystickPosition();
            _joystick.gameObject.SetActive(false);
        }

        private void SetJoystickPosition()
        {
            _internalJoystick.anchoredPosition = Direction * DistanceRation * _maxDistance;
        }

        private void ResetJoystickPosition()
        {
            Direction = Vector2.zero;
            DistanceRation = 0f;
            SetJoystickPosition();
        }
    }
}