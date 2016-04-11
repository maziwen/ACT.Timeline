﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FairyZeta.FF14.ACT.Timeline.Core.Data
{
    /// <summary> タイムライン／プラグイン設定データ
    /// </summary>
    [Serializable]
    public class PluginSettingsData : _Data
    {
      /*--- Property/Field Definitions ------------------------------------------------------------------------------------------------------------------------------*/

        #region #- [Property] bool.AllOverlayVisibility - ＜全オーバーレイの表示状態＞ -----
        /// <summary> 全オーバーレイの表示状態 </summary>
        private bool _AllOverlayVisibility;
        /// <summary> 全オーバーレイの表示状態 </summary>
        public bool AllOverlayVisibility
        {
            get { return this._AllOverlayVisibility; }
            set
            {
                if (this._AllOverlayVisibility == value) return;

                this._AllOverlayVisibility = value;
                base.OnPropertyChanged("AllOverlayVisibility");
                base.SaveChangedTarget = true;
            }
        }
        #endregion

        /// <summary> このプラグインDLLまでのパス
        /// </summary>
        public string PluginDllPath { get; set; }

        #region #- [Property] string.TimelineResourceDirectory - ＜タイムラインリソースディレクトリ＞ -----
        /// <summary> タイムラインリソースディレクトリ </summary>
        private string _TimelineResourceDirectory;
        /// <summary> タイムラインリソースディレクトリ </summary>
        public string TimelineResourceDirectory
        {
            get { return this._TimelineResourceDirectory; }
            set
            {
                if (this._TimelineResourceDirectory == value) return;

                this._TimelineResourceDirectory = value;
                base.OnPropertyChanged("TimelineResourceDirectory");
                base.SaveChangedTarget = true;
            }
        }
        #endregion
        #region #- [Property] string.SoundResourceDirectory - ＜サウンドリソースディレクトリ＞ -----
        /// <summary> サウンドリソースディレクトリ </summary>
        private string _SoundResourceDirectory;
        /// <summary> サウンドリソースディレクトリ </summary>
        public string SoundResourceDirectory
        {
            get { return this._SoundResourceDirectory; }
            set
            {
                if (this._SoundResourceDirectory == value) return;

                this._SoundResourceDirectory = value;
                base.OnPropertyChanged("SoundResourceDirectory");
                base.SaveChangedTarget = true;
            }
        }
        #endregion

      /*--- Constructers --------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> タイムライン／プラグイン設定データ／コンストラクタ
        /// </summary>
        public PluginSettingsData()
        {
            this.initData();
            this.clear();
        }

      /*--- Method: Initialization ----------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> データの初期化を実行します。
        /// </summary>
        /// <returns> 正常終了時 True </returns> 
        private bool initData()
        {
            return true;
        }

      /*--- Method: public ------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> データの全体クリアを実行します。
        /// </summary>
        /// <returns> 正常終了時 True </returns> 
        public override bool Clear()
        {
            base.Clear();
            this.clear();

            return true;
        }

      /*--- Method: private -----------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> データの単体クリアを実行します。
        /// </summary>
        /// <returns> 正常終了時 True </returns> 
        private bool clear()
        {
            this.AllOverlayVisibility = false;

            this.PluginDllPath = string.Empty;
            this.SoundResourceDirectory = string.Empty;
            this.TimelineResourceDirectory = string.Empty;

            return true;
        }
    }
}
