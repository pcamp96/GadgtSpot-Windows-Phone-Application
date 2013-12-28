// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Main_News ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IMain_NewsViewModel
    {		
	    /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        Visibility IsInternetAvalaible { get; }
        /// <summary>
        /// Gets/Sets the Main_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Main_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedMain_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedMain_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the NewsFeed_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> NewsFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedNewsFeed_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedNewsFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the ReviewsFeed_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> ReviewsFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedReviewsFeed_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedReviewsFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the GiveawaysFeed_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> GiveawaysFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedGiveawaysFeed_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedGiveawaysFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the EditorialFeed_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> EditorialFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedEditorialFeed_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedEditorialFeed_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_videosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> Videos_videosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_videosListControlCollectionPageNumber property.
        /// </summary>
		int Videos_videosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedVideos_videosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedVideos_videosListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshMain_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshMain_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetMain_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetMain_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshNewsFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetNewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetNewsFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshReviewsFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetReviewsFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetReviewsFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshGiveawaysFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetGiveawaysFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetGiveawaysFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshEditorialFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetEditorialFeed_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetEditorialFeed_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshVideos_videosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
		ICommand GetVideos_videosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}
