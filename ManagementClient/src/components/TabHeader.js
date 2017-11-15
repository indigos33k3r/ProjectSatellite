import React from 'react';
import PropTypes from 'prop-types';
import { NavLink } from 'react-router-dom';

const TabHeader = ({Headers, Prefix}) => (
  <div>
    {Headers.map((h) => <NavLink key={`TH_${Prefix}_${h}`} to={(Prefix ? '/' + Prefix + '/' : '/') + h}>{h}</NavLink>)}
  </div>
);

TabHeader.propTypes = {
  Headers: PropTypes.arrayOf(PropTypes.string).isRequired,
  Prefix: PropTypes.string
};
 

export default TabHeader;
