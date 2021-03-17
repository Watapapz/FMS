// "Production" enabled environment

export const environment = {
    production: true,
    hmr: false,
    appConfig: 'appconfig.' + (window["env"]["ASPNETCORE_ENVIRONMENT"] || 'prod') +'.json'
};
