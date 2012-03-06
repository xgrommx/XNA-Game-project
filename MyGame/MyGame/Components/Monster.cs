﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkinnedModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Helper;
using control;

namespace MyGame
{
    public class Monster : CDrawableComponent
    {
        public Monster(Game1 game, SkinningData runSkinningData, SkinningData dieSkinningData, Model model, Unit unit)
            : base(game, unit)
        {
            cModel = new MonsterModel(myGame, runSkinningData, dieSkinningData, model);
            unit.BoundingSphere = cModel.buildBoundingSphere();
        }

        public override void Update(GameTime gameTime)
        {
            Vector3 pos = unit.position;
            unit.position.Y = myGame.terrain.GetHeightAtPosition(pos.X, pos.Z);
            base.Update(gameTime);
        }
    }
}
