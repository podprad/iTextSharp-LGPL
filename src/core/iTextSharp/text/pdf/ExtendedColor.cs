using System;

using iTextSharp4.text;

/*
 * $Id: ExtendedColor.cs,v 1.4 2008/05/13 11:25:17 psoares33 Exp $
 * 
 *
 * Copyright 2001, 2002 by Paulo Soares.
 *
 * The contents of this file are subject to the Mozilla Public License Version 1.1
 * (the "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the License.
 *
 * The Original Code is 'iText, a free JAVA-PDF library'.
 *
 * The Initial Developer of the Original Code is Bruno Lowagie. Portions created by
 * the Initial Developer are Copyright (C) 1999, 2000, 2001, 2002 by Bruno Lowagie.
 * All Rights Reserved.
 * Co-Developer of the code is Paulo Soares. Portions created by the Co-Developer
 * are Copyright (C) 2000, 2001, 2002 by Paulo Soares. All Rights Reserved.
 *
 * Contributor(s): all the names of the contributors are added in the source code
 * where applicable.
 *
 * Alternatively, the contents of this file may be used under the terms of the
 * LGPL license (the "GNU LIBRARY GENERAL PUBLIC LICENSE"), in which case the
 * provisions of LGPL are applicable instead of those above.  If you wish to
 * allow use of your version of this file only under the terms of the LGPL
 * License and not to allow others to use your version of this file under
 * the MPL, indicate your decision by deleting the provisions above and
 * replace them with the notice and other provisions required by the LGPL.
 * If you do not delete the provisions above, a recipient may use your version
 * of this file under either the MPL or the GNU LIBRARY GENERAL PUBLIC LICENSE.
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the MPL as stated above or under the terms of the GNU
 * Library General Public License as published by the Free Software Foundation;
 * either version 2 of the License, or any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU Library general Public License for more
 * details.
 *
 * If you didn't download this code from the following link, you should check if
 * you aren't using an obsolete version:
 * http://www.lowagie.com/iText/
 */

namespace iTextSharp4.text.pdf {

    /**
     *
     * @author  Paulo Soares (psoares@consiste.pt)
     */
    //public class ExtendedColor : Color {
    public abstract class ExtendedColor : Color {
    
        internal const int TYPE_RGB = 0;
        internal const int TYPE_GRAY = 1;
        internal const int TYPE_CMYK = 2;
        internal const int TYPE_SEPARATION = 3;
        internal const int TYPE_PATTERN = 4;
        internal const int TYPE_SHADING = 5;
    
        protected int type;

        public ExtendedColor(int type) : base(0, 0, 0) {
            this.type = type;
        }
    
        public ExtendedColor(int type, float red, float green, float blue) : base(Normalize(red), Normalize(green), Normalize(blue)) {
            this.type = type;
        }
    
        public int Type {
            get {
                return type;
            }
        }
    
        public static int GetType(object color) {
            if (color is ExtendedColor)
                return ((ExtendedColor)color).Type;
            return TYPE_RGB;
        }

        internal static float Normalize(float value) {
            if (value < 0)
                return 0;
            if (value > 1)
                return 1;
            return (float)value;
        }
    }
}