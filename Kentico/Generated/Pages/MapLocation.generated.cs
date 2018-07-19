//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Training;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MapLocation.CLASS_NAME, typeof(MapLocation))]

namespace CMS.DocumentEngine.Types.Training
{
    /// <summary>
    /// Represents a content item of type MapLocation.
    /// </summary>
    public partial class MapLocation : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "Training.MapLocation";


        /// <summary>
        /// The instance of the class that provides extended API for working with MapLocation fields.
        /// </summary>
        private readonly MapLocationFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// MapLocationID.
        /// </summary>
        [DatabaseIDField]
        public int MapLocationID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("MapLocationID"), 0);
            }
            set
            {
                SetValue("MapLocationID", value);
            }
        }


        /// <summary>
        /// Latitude.
        /// </summary>
        [DatabaseField]
        public double Latitude
        {
            get
            {
                return ValidationHelper.GetDouble(GetValue("Latitude"), 0);
            }
            set
            {
                SetValue("Latitude", value);
            }
        }


        /// <summary>
        /// Longitude.
        /// </summary>
        [DatabaseField]
        public double Longitude
        {
            get
            {
                return ValidationHelper.GetDouble(GetValue("Longitude"), 0);
            }
            set
            {
                SetValue("Longitude", value);
            }
        }


        /// <summary>
        /// Tooltip text.
        /// </summary>
        [DatabaseField]
        public string Tooltip
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Tooltip"), @"");
            }
            set
            {
                SetValue("Tooltip", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with MapLocation fields.
        /// </summary>
        [RegisterProperty]
        public MapLocationFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with MapLocation fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class MapLocationFields : AbstractHierarchicalObject<MapLocationFields>
        {
            /// <summary>
            /// The content item of type MapLocation that is a target of the extended API.
            /// </summary>
            private readonly MapLocation mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="MapLocationFields" /> class with the specified content item of type MapLocation.
            /// </summary>
            /// <param name="instance">The content item of type MapLocation that is a target of the extended API.</param>
            public MapLocationFields(MapLocation instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// MapLocationID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.MapLocationID;
                }
                set
                {
                    mInstance.MapLocationID = value;
                }
            }


            /// <summary>
            /// Latitude.
            /// </summary>
            public double Latitude
            {
                get
                {
                    return mInstance.Latitude;
                }
                set
                {
                    mInstance.Latitude = value;
                }
            }


            /// <summary>
            /// Longitude.
            /// </summary>
            public double Longitude
            {
                get
                {
                    return mInstance.Longitude;
                }
                set
                {
                    mInstance.Longitude = value;
                }
            }


            /// <summary>
            /// Tooltip text.
            /// </summary>
            public string Tooltip
            {
                get
                {
                    return mInstance.Tooltip;
                }
                set
                {
                    mInstance.Tooltip = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="MapLocation" /> class.
        /// </summary>
        public MapLocation() : base(CLASS_NAME)
        {
            mFields = new MapLocationFields(this);
        }

        #endregion
    }
}