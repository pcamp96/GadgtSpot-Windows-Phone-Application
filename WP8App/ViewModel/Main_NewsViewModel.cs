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
    /// Implementation of Main_News ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Main_NewsViewModel : ViewModelsBase.VMBase, IViewModels.IMain_NewsViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ILockScreenService _lockScreenService;
		private readonly Repositories.IMain_mainrssfeed _main_mainrssfeed;
		private readonly Repositories.INewsFeed_NewsFeed _newsFeed_NewsFeed;
		private readonly Repositories.IReviewsFeed_ReviewsFeed _reviewsFeed_ReviewsFeed;
		private readonly Repositories.IGiveawaysFeed_GiveawaysFeed _giveawaysFeed_GiveawaysFeed;
		private readonly Repositories.IEditorialFeed_EditorialFeed _editorialFeed_EditorialFeed;
		private readonly Repositories.IVideos_Videos _videos_Videos;
		private readonly IServices.IInternetService _internetService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Main_NewsViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="main_mainrssfeed">The Main_mainrssfeed.</param>
        /// <param name="newsFeed_NewsFeed">The News Feed_ News Feed.</param>
        /// <param name="reviewsFeed_ReviewsFeed">The Reviews Feed_ Reviews Feed.</param>
        /// <param name="giveawaysFeed_GiveawaysFeed">The Giveaways Feed_ Giveaways Feed.</param>
        /// <param name="editorialFeed_EditorialFeed">The Editorial Feed_ Editorial Feed.</param>
        /// <param name="videos_Videos">The Videos_ Videos.</param>
        /// <param name="internetService">The Internet Service.</param>
        public Main_NewsViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService, Repositories.IMain_mainrssfeed main_mainrssfeed, Repositories.INewsFeed_NewsFeed newsFeed_NewsFeed, Repositories.IReviewsFeed_ReviewsFeed reviewsFeed_ReviewsFeed, Repositories.IGiveawaysFeed_GiveawaysFeed giveawaysFeed_GiveawaysFeed, Repositories.IEditorialFeed_EditorialFeed editorialFeed_EditorialFeed, Repositories.IVideos_Videos videos_Videos, IServices.IInternetService internetService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_main_mainrssfeed = main_mainrssfeed;
			_newsFeed_NewsFeed = newsFeed_NewsFeed;
			_reviewsFeed_ReviewsFeed = reviewsFeed_ReviewsFeed;
			_giveawaysFeed_GiveawaysFeed = giveawaysFeed_GiveawaysFeed;
			_editorialFeed_EditorialFeed = editorialFeed_EditorialFeed;
			_videos_Videos = videos_Videos;
			_internetService = internetService;
        }
		
	    /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        public Visibility IsInternetAvalaible
        {
	      get
          {
				return _internetService.IsNetworkAvailable() ? Visibility.Collapsed : Visibility.Visible; 
           }
		}
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _main_NewsListControlCollection;

        /// <summary>
        /// Main_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Main_NewsListControlCollection
        {
            get
            {
				
                if(_main_NewsListControlCollection == null)
					GetMain_NewsListControlCollectionData();
				return _main_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _main_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedMain_NewsListControlCollection;

        /// <summary>
        /// SelectedMain_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedMain_NewsListControlCollection
        {
            get
            {
				return _selectedMain_NewsListControlCollection;
            }
            set
            {
                _selectedMain_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IMain_DetailViewModel>(_selectedMain_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _newsFeed_NewsListControlCollection;

        /// <summary>
        /// NewsFeed_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> NewsFeed_NewsListControlCollection
        {
            get
            {
				
                if(_newsFeed_NewsListControlCollection == null)
					GetNewsFeed_NewsListControlCollectionData();
				return _newsFeed_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _newsFeed_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedNewsFeed_NewsListControlCollection;

        /// <summary>
        /// SelectedNewsFeed_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedNewsFeed_NewsListControlCollection
        {
            get
            {
				return _selectedNewsFeed_NewsListControlCollection;
            }
            set
            {
                _selectedNewsFeed_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.INewsFeed_DetailViewModel>(_selectedNewsFeed_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _reviewsFeed_NewsListControlCollection;

        /// <summary>
        /// ReviewsFeed_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> ReviewsFeed_NewsListControlCollection
        {
            get
            {
				
                if(_reviewsFeed_NewsListControlCollection == null)
					GetReviewsFeed_NewsListControlCollectionData();
				return _reviewsFeed_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _reviewsFeed_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedReviewsFeed_NewsListControlCollection;

        /// <summary>
        /// SelectedReviewsFeed_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedReviewsFeed_NewsListControlCollection
        {
            get
            {
				return _selectedReviewsFeed_NewsListControlCollection;
            }
            set
            {
                _selectedReviewsFeed_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IReviewsFeed_DetailViewModel>(_selectedReviewsFeed_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _giveawaysFeed_NewsListControlCollection;

        /// <summary>
        /// GiveawaysFeed_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> GiveawaysFeed_NewsListControlCollection
        {
            get
            {
				
                if(_giveawaysFeed_NewsListControlCollection == null)
					GetGiveawaysFeed_NewsListControlCollectionData();
				return _giveawaysFeed_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _giveawaysFeed_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedGiveawaysFeed_NewsListControlCollection;

        /// <summary>
        /// SelectedGiveawaysFeed_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedGiveawaysFeed_NewsListControlCollection
        {
            get
            {
				return _selectedGiveawaysFeed_NewsListControlCollection;
            }
            set
            {
                _selectedGiveawaysFeed_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IGiveawaysFeed_DetailViewModel>(_selectedGiveawaysFeed_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _editorialFeed_NewsListControlCollection;

        /// <summary>
        /// EditorialFeed_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> EditorialFeed_NewsListControlCollection
        {
            get
            {
				
                if(_editorialFeed_NewsListControlCollection == null)
					GetEditorialFeed_NewsListControlCollectionData();
				return _editorialFeed_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _editorialFeed_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedEditorialFeed_NewsListControlCollection;

        /// <summary>
        /// SelectedEditorialFeed_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedEditorialFeed_NewsListControlCollection
        {
            get
            {
				return _selectedEditorialFeed_NewsListControlCollection;
            }
            set
            {
                _selectedEditorialFeed_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IEditorialFeed_DetailViewModel>(_selectedEditorialFeed_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.YouTubeVideo> _videos_videosListControlCollection;

        /// <summary>
        /// Videos_videosListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.YouTubeVideo> Videos_videosListControlCollection
        {
            get
            {
				
                if(_videos_videosListControlCollection == null)
					GetVideos_videosListControlCollectionData();
				return _videos_videosListControlCollection;     
            }
            set
            {
                SetProperty(ref _videos_videosListControlCollection, value);
            }
        }
	
		private int _videos_videosListControlCollectionPageNumber;

        /// <summary>
        /// Videos_videosListControlCollectionPageNumber property.
        /// </summary>		
        public int Videos_videosListControlCollectionPageNumber
        {
            get
            {
				return _videos_videosListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _videos_videosListControlCollectionPageNumber, value);
            }
        }
	
		private EntitiesBase.YouTubeVideo _selectedVideos_videosListControlCollection;

        /// <summary>
        /// SelectedVideos_videosListControlCollection property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo SelectedVideos_videosListControlCollection
        {
            get
            {
				return _selectedVideos_videosListControlCollection;
            }
            set
            {
                _selectedVideos_videosListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IVideos_DetailVideosViewModel>(_selectedVideos_videosListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshMain_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshMain_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingMain_NewsListControlCollection = true;
				var items = await  _main_mainrssfeed.Refresh();
				Main_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Main_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMain_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingMain_NewsListControlCollection;
		
        public bool LoadingMain_NewsListControlCollection
        {
            get { return _loadingMain_NewsListControlCollection; }
            set { SetProperty(ref _loadingMain_NewsListControlCollection, value); }
        }

        private ICommand _refreshMain_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshMain_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshMain_NewsListControlCollectionCommand
        {
            get { return _refreshMain_NewsListControlCollectionCommand = _refreshMain_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshMain_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetMain_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetMain_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetMain_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getMain_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetMain_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetMain_NewsListControlCollectionCommand
        {
            get { return _getMain_NewsListControlCollectionCommand = _getMain_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetMain_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshNewsFeed_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingNewsFeed_NewsListControlCollection = true;
				var items = await  _newsFeed_NewsFeed.Refresh();
				NewsFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				NewsFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingNewsFeed_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingNewsFeed_NewsListControlCollection;
		
        public bool LoadingNewsFeed_NewsListControlCollection
        {
            get { return _loadingNewsFeed_NewsListControlCollection; }
            set { SetProperty(ref _loadingNewsFeed_NewsListControlCollection, value); }
        }

        private ICommand _refreshNewsFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshNewsFeed_NewsListControlCollectionCommand
        {
            get { return _refreshNewsFeed_NewsListControlCollectionCommand = _refreshNewsFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshNewsFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetNewsFeed_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetNewsFeed_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getNewsFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetNewsFeed_NewsListControlCollectionCommand
        {
            get { return _getNewsFeed_NewsListControlCollectionCommand = _getNewsFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetNewsFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshReviewsFeed_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingReviewsFeed_NewsListControlCollection = true;
				var items = await  _reviewsFeed_ReviewsFeed.Refresh();
				ReviewsFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				ReviewsFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingReviewsFeed_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingReviewsFeed_NewsListControlCollection;
		
        public bool LoadingReviewsFeed_NewsListControlCollection
        {
            get { return _loadingReviewsFeed_NewsListControlCollection; }
            set { SetProperty(ref _loadingReviewsFeed_NewsListControlCollection, value); }
        }

        private ICommand _refreshReviewsFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshReviewsFeed_NewsListControlCollectionCommand
        {
            get { return _refreshReviewsFeed_NewsListControlCollectionCommand = _refreshReviewsFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshReviewsFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetReviewsFeed_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetReviewsFeed_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getReviewsFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetReviewsFeed_NewsListControlCollectionCommand
        {
            get { return _getReviewsFeed_NewsListControlCollectionCommand = _getReviewsFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetReviewsFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshGiveawaysFeed_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingGiveawaysFeed_NewsListControlCollection = true;
				var items = await  _giveawaysFeed_GiveawaysFeed.Refresh();
				GiveawaysFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				GiveawaysFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingGiveawaysFeed_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingGiveawaysFeed_NewsListControlCollection;
		
        public bool LoadingGiveawaysFeed_NewsListControlCollection
        {
            get { return _loadingGiveawaysFeed_NewsListControlCollection; }
            set { SetProperty(ref _loadingGiveawaysFeed_NewsListControlCollection, value); }
        }

        private ICommand _refreshGiveawaysFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshGiveawaysFeed_NewsListControlCollectionCommand
        {
            get { return _refreshGiveawaysFeed_NewsListControlCollectionCommand = _refreshGiveawaysFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshGiveawaysFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetGiveawaysFeed_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetGiveawaysFeed_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getGiveawaysFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetGiveawaysFeed_NewsListControlCollectionCommand
        {
            get { return _getGiveawaysFeed_NewsListControlCollectionCommand = _getGiveawaysFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetGiveawaysFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshEditorialFeed_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingEditorialFeed_NewsListControlCollection = true;
				var items = await  _editorialFeed_EditorialFeed.Refresh();
				EditorialFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				EditorialFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingEditorialFeed_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingEditorialFeed_NewsListControlCollection;
		
        public bool LoadingEditorialFeed_NewsListControlCollection
        {
            get { return _loadingEditorialFeed_NewsListControlCollection; }
            set { SetProperty(ref _loadingEditorialFeed_NewsListControlCollection, value); }
        }

        private ICommand _refreshEditorialFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshEditorialFeed_NewsListControlCollectionCommand
        {
            get { return _refreshEditorialFeed_NewsListControlCollectionCommand = _refreshEditorialFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshEditorialFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetEditorialFeed_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetEditorialFeed_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getEditorialFeed_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetEditorialFeed_NewsListControlCollectionCommand
        {
            get { return _getEditorialFeed_NewsListControlCollectionCommand = _getEditorialFeed_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetEditorialFeed_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
        public async void RefreshVideos_videosListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingVideos_videosListControlCollection = true;
				var items = await  _videos_Videos.Refresh();
				Videos_videosListControlCollection = items;
				Videos_videosListControlCollectionPageNumber = 0;
			}
            catch (Exception ex)
            {
				Videos_videosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingVideos_videosListControlCollection = false;
			}
        }
		
		
        private bool _loadingVideos_videosListControlCollection;
		
        public bool LoadingVideos_videosListControlCollection
        {
            get { return _loadingVideos_videosListControlCollection; }
            set { SetProperty(ref _loadingVideos_videosListControlCollection, value); }
        }

        private ICommand _refreshVideos_videosListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshVideos_videosListControlCollectionCommand
        {
            get { return _refreshVideos_videosListControlCollectionCommand = _refreshVideos_videosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshVideos_videosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
        public  void GetVideos_videosListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetVideos_videosListControlCollectionData(pageNumber);
        }
		

        private ICommand _getVideos_videosListControlCollectionCommand;

        /// <summary>
        /// Gets the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
        public ICommand GetVideos_videosListControlCollectionCommand
        {
            get { return _getVideos_videosListControlCollectionCommand = _getVideos_videosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetVideos_videosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
				_lockScreenService.SetLockScreen("LockScreen-419db029-832e-40f5-b5e8-3f908ffccbac.jpg");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }

        private async void GetMain_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingMain_NewsListControlCollection = true;
			
				var items = await _main_mainrssfeed.GetData();
                Main_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Main_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMain_NewsListControlCollection = false;
			}
		}

        private async void GetNewsFeed_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingNewsFeed_NewsListControlCollection = true;
			
				var items = await _newsFeed_NewsFeed.GetData();
                NewsFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				NewsFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingNewsFeed_NewsListControlCollection = false;
			}
		}

        private async void GetReviewsFeed_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingReviewsFeed_NewsListControlCollection = true;
			
				var items = await _reviewsFeed_ReviewsFeed.GetData();
                ReviewsFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				ReviewsFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingReviewsFeed_NewsListControlCollection = false;
			}
		}

        private async void GetGiveawaysFeed_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingGiveawaysFeed_NewsListControlCollection = true;
			
				var items = await _giveawaysFeed_GiveawaysFeed.GetData();
                GiveawaysFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				GiveawaysFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingGiveawaysFeed_NewsListControlCollection = false;
			}
		}

        private async void GetEditorialFeed_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingEditorialFeed_NewsListControlCollection = true;
			
				var items = await _editorialFeed_EditorialFeed.GetData();
                EditorialFeed_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				EditorialFeed_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingEditorialFeed_NewsListControlCollection = false;
			}
		}

        private async void GetVideos_videosListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingVideos_videosListControlCollection = true;
				Videos_videosListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
				{
					var items = await _videos_Videos.GetData(pageNumber);
                    Videos_videosListControlCollection = items;
				}
                else   
				{
					var items = await _videos_Videos.GetData(pageNumber);
                    foreach (var item in items)                    
                        Videos_videosListControlCollection.Add(item);
				}
			}
            catch (Exception ex)
            {
				Videos_videosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingVideos_videosListControlCollection = false;
			}
		}
    }
}
