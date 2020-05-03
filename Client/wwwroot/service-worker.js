self.addEventListener('install', async event => {
    console.log('Installing service worker...');
    self.skipWaiting();
});

self.addEventListener('fetch', event => {
    /* you can custom logic here for controlling whether to use cached data if offline, etc
        The following line opts out, so reuests go directly to the network as usual*/
    return null;
});