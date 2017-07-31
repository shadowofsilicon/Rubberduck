﻿using Rubberduck.Parsing.VBA;
using Rubberduck.UI.Command.MenuItems.ParentMenus;

namespace Rubberduck.UI.Command.MenuItems
{
    class ExportAllCommandMenuItem : CommandMenuItemBase
    {
        public ExportAllCommandMenuItem(CommandBase command) : base(command)
        {
        }

        public override string Key => "ToolsMenu_ExportAll";

        public override int DisplayOrder => (int)ToolsMenuItemDisplayOrder.ExportAll;

        public override bool EvaluateCanExecute(RubberduckParserState state)
        {
            return true;
        }
    }
}