﻿using System;

using AppKit;
using SpriteKit;
using Foundation;
using CoreGraphics;

namespace StoryGame
{
    public class GameScene : SKScene
    {
        public GameScene(IntPtr handle) : base(handle)
        {
        }

        public override void DidMoveToView(SKView view)
        {
            // Setup your scene here
            var myLabel = SKLabelNode.FromFont("Trebuchet MS");

            myLabel.Text = "Starting..";
            myLabel.FontSize = 44;
            myLabel.Position = new CGPoint(Frame.GetMidX(), Frame.GetMidY());

            AddChild(myLabel);
        }

        public override void MouseDown(NSEvent theEvent)
        {
            // Called when a mouse click occurs

            var location = theEvent.LocationInNode(this);

            var sprite = SKSpriteNode.FromImageNamed(NSBundle.MainBundle.PathForResource("Spaceship", "png"));

            sprite.Position = location;
            sprite.SetScale(0.2f);

            AddChild(sprite);
        }

        public override void Update(double currentTime)
        {
            // Called before each frame is rendered
        }
    }
}
