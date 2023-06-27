using System;
using System.Threading.Tasks;
using AsyncEvent;

namespace TaF.LegionTD2Api.InternalHttpClient
{
    public partial class InternalClient
    {
        #region BeforeRequest

        public event AsyncEventHandler<ClientRequestEventArgs> BeforeRequestAsync;

        public async Task OnBeforeRequestAsync(ClientRequestEventArgs e)
        {
            BeforeRequestAsync?.InvokeAsync(this, e);
        }

        public event EventHandler BeforeRequest;

        protected virtual void OnBeforeRequest(ClientRequestEventArgs e)
        {
            BeforeRequest?.Invoke(this, e);
        }

        #endregion

        #region SuccessRequest

        public event AsyncEventHandler<ClientRequestEventArgs> SuccessRequestAsync;

        private Task OnSuccessRequestAsync(ClientRequestEventArgs e)
        {
            SuccessRequestAsync?.InvokeAsync(this, e);
            return Task.CompletedTask;
        }

        public event EventHandler SuccessRequest;

        protected virtual void OnSuccessRequest(ClientRequestEventArgs e)
        {
            SuccessRequest?.Invoke(this, e);
        }

        #endregion

        #region ErrorRequest

        public event AsyncEventHandler<ClientRequestErrorEventArgs> ErrorRequestAsync;

        public async Task OnErrorRequestAsync(ClientRequestErrorEventArgs e)
        {
            ErrorRequestAsync?.InvokeAsync(this, e);
        }

        public event EventHandler ErrorRequest;

        protected virtual void OnErrorRequest(ClientRequestErrorEventArgs e)
        {
            ErrorRequest?.Invoke(this, e);
        }

        #endregion

        #region CompletedRequest

        public event AsyncEventHandler<ClientRequestEventArgs> CompletedRequestAsync;

        public async Task OnCompletedRequestAsync(ClientRequestEventArgs e)
        {
            CompletedRequestAsync?.InvokeAsync(this, e);
        }

        public event EventHandler CompletedRequest;

        protected virtual void OnCompletedRequest(ClientRequestEventArgs e)
        {
            CompletedRequest?.Invoke(this, e);
        }

        #endregion
    }
}