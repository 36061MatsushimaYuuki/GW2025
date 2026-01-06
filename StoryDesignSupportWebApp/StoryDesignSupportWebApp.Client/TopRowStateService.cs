namespace StoryDesignSupportWebApp.Client {
    public class TopRowStateService {
        private bool _isCollapsed = false;

        public bool IsCollapsed {
            get => _isCollapsed;
            set {
                if (_isCollapsed != value) {
                    _isCollapsed = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
