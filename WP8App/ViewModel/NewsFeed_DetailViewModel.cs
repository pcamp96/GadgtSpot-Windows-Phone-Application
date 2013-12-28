// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of NewsFeed_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class NewsFeed_DetailViewModel : ViewModelsBase.VMBase, IViewModels.INewsFeed_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.NewsFeed_NewsFeed _newsFeed_NewsFeed;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NewsFeed_DetailViewModel" /> class.
        /// </summary>
        /// <param name="newsFeed_NewsFeed">The News Feed_ News Feed.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public NewsFeed_DetailViewModel(Repositories.NewsFeed_NewsFeed newsFeed_NewsFeed, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_newsFeed_NewsFeed = newsFeed_NewsFeed;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private EntitiesBase.RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public EntitiesBase.RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }
	
		private bool _hasNextpanoramaNewsFeed_Detail0;

        /// <summary>
        /// HasNextpanoramaNewsFeed_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaNewsFeed_Detail0
        {
            get
            {
				return _hasNextpanoramaNewsFeed_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaNewsFeed_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaNewsFeed_Detail0;

        /// <summary>
        /// HasPreviouspanoramaNewsFeed_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaNewsFeed_Detail0
        {
            get
            {
				return _hasPreviouspanoramaNewsFeed_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaNewsFeed_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechNewsFeed_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechNewsFeed_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechNewsFeed_DetailStaticControlCommand
        {
            get { return _textToSpeechNewsFeed_DetailStaticControlCommand = _textToSpeechNewsFeed_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechNewsFeed_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareNewsFeed_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl, CurrentRssSearchResult.ImageUrl);
        }
		

        private ICommand _shareNewsFeed_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareNewsFeed_DetailStaticControlCommand
        {
            get { return _shareNewsFeed_DetailStaticControlCommand = _shareNewsFeed_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareNewsFeed_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartNewsFeed_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.INewsFeed_DetailViewModel), CreateTileInfoNewsFeed_DetailStaticControl());
        }
		

        private ICommand _pinToStartNewsFeed_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartNewsFeed_DetailStaticControlCommand
        {
            get { return _pinToStartNewsFeed_DetailStaticControlCommand = _pinToStartNewsFeed_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartNewsFeed_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceNewsFeed_DetailStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceNewsFeed_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceNewsFeed_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceNewsFeed_DetailStaticControlCommand
        {
            get { return _goToSourceNewsFeed_DetailStaticControlCommand = _goToSourceNewsFeed_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceNewsFeed_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaNewsFeed_Detail0 command.
        /// </summary>
        public async void NextpanoramaNewsFeed_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var next = await  _newsFeed_NewsFeed.Next(CurrentRssSearchResult);

			if(next != null)
				CurrentRssSearchResult = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentRssSearchResult;
		
        public bool LoadingCurrentRssSearchResult
        {
            get { return _loadingCurrentRssSearchResult; }
            set { SetProperty(ref _loadingCurrentRssSearchResult, value); }
        }

        private ICommand _nextpanoramaNewsFeed_Detail0;

        /// <summary>
        /// Gets the NextpanoramaNewsFeed_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaNewsFeed_Detail0
        {
            get { return _nextpanoramaNewsFeed_Detail0 = _nextpanoramaNewsFeed_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaNewsFeed_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaNewsFeed_Detail0 command.
        /// </summary>
        public async void PreviouspanoramaNewsFeed_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var prev = await  _newsFeed_NewsFeed.Previous(CurrentRssSearchResult);

			if(prev != null)
				CurrentRssSearchResult = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaNewsFeed_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaNewsFeed_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaNewsFeed_Detail0
        {
            get { return _previouspanoramaNewsFeed_Detail0 = _previouspanoramaNewsFeed_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaNewsFeed_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaNewsFeed_Detail0 = await _newsFeed_NewsFeed.HasPrevious(CurrentRssSearchResult);
			HasNextpanoramaNewsFeed_Detail0 = await _newsFeed_NewsFeed.HasNext(CurrentRssSearchResult);
			LoadingCurrentRssSearchResult = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as EntitiesBase.RssSearchResult;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the NewsFeed_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoNewsFeed_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-242457de-80da-42c9-9fbb-98b5451c622c.png"
            };
            return tileInfo;
        }
    }
}
