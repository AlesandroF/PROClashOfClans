Eu tive o mesmo problema no Ubuntu 18.10, N� 10.8.0, NPM 6.2.0 e Angular CLI 6.2.6.

Corrigido com a remo��o de op��o de cores neste arquivo: 
/node_modules/@angular-devkit/build-angular/src/angular-cli-files/models/webpack-configs/common.js 
on Line: 123

Mudou isto: 
extraPlugins.push (new ProgressPlugin ({profile: buildOptions.verbose, colors: true})); 
para: 
extraPlugins.push (new ProgressPlugin ({profile: buildOptions.verbose}));

Espero que esta ajuda. Felicidades.