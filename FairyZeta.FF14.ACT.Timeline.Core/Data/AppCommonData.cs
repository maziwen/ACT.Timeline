﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyZeta.FF14.ACT.Timeline.Core.Data
{
    /// <summary> タイムライン／共通データ
    /// </summary>
    public class AppCommonData : _Data
    {
      /*--- Property/Field Definitions ------------------------------------------------------------------------------------------------------------------------------*/

        #region #- [Property] string.TimelineDirectoryStatus - ＜タイムラインディレクトリステータス＞ -----
        /// <summary> タイムラインディレクトリステータス </summary>
        private string _TimelineDirectoryStatus;
        /// <summary> タイムラインディレクトリステータス </summary>
        public string TimelineDirectoryStatus
        {
            get { return this._TimelineDirectoryStatus; }
            set
            {
                if (this._TimelineDirectoryStatus == value) return;

                this._TimelineDirectoryStatus = value;
                base.OnPropertyChanged("TimelineDirectoryStatus");
            }
        }
        #endregion
        #region #- [Property] string.SoundDirectoryStatus - ＜サウンドディレクトリステータス＞ -----
        /// <summary> サウンドディレクトリステータス </summary>
        private string _SoundDirectoryStatus;
        /// <summary> サウンドディレクトリステータス </summary>
        public string SoundDirectoryStatus
        {
            get { return this._SoundDirectoryStatus; }
            set
            {
                if (this._SoundDirectoryStatus == value) return;

                this._SoundDirectoryStatus = value;
                base.OnPropertyChanged("SoundDirectoryStatus");
            }
        }
        #endregion

        #region #- [Property] string.TimelineLoadErrorMsg - ＜タイムラインロードエラーメッセージ＞ -----
        /// <summary> タイムラインロードエラーメッセージ </summary>
        private string _TimelineLoadErrorMsg;
        /// <summary> タイムラインロードエラーメッセージ </summary>
        public string TimelineLoadErrorMsg
        {
            get { return this._TimelineLoadErrorMsg; }
            set
            {
                if (this._TimelineLoadErrorMsg == value) return;

                this._TimelineLoadErrorMsg = value;
                base.OnPropertyChanged("TimelineLoadErrorMsg");
            }
        }
        #endregion

        #region #- [Property] string.TimelineViewStatusMsg - ＜タイムライン表示状態メッセージ＞ -----
        /// <summary> タイムライン表示状態メッセージ </summary>
        private string _TimelineViewStatusMsg;
        /// <summary> タイムライン表示状態メッセージ </summary>    
        public string TimelineViewStatusMsg
        {
            get { return _TimelineViewStatusMsg; }
            set { this.SetProperty(ref this._TimelineViewStatusMsg, value); }
        }
        #endregion

        /// <summary> 現在オープンしている画面のIntPtrList
        /// </summary>
        public List<IntPtr> ViewIntPtrList { get; private set; }

      /*--- Constructers --------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> タイムライン／共通データ／コンストラクタ
        /// </summary>
        public AppCommonData()
            : base()
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
            this.ViewIntPtrList = new List<IntPtr>();

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
            this.TimelineDirectoryStatus = string.Empty;
            this.SoundDirectoryStatus = string.Empty;

            return true;
        }
    }
}
