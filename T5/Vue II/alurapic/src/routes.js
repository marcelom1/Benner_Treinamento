import Cadastro from './componentes/cadastro/Cadastro.vue';
import Home from './componentes/home/home.vue';


export const routes =[
    {path: '',component: Home, titulo:'Home'},
    {path: '/cadastro',component: Cadastro, titulo: 'Cadastro'}
];